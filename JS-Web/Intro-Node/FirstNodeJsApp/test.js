const config = require('./config.json');
const http = require('http');
const fs = require('fs');
const url = require('url');
const path = require('path');
const stream = require('stream');
const zlib = require('zlib');

//#region Comments
// function createReadableStream(data) {
// 	let counter = 0;
// 	const rs = stream.Readable({
// 		read(size) {
// 			const item = data[counter++] || null;
// 			this.push(item ? Buffer.from(item.toString()) : null);
// 		},
// 	});
// 	return rs;
// }

// function createWritableStream() {
// 	let data;
// 	const ws = stream.Writable({
// 		write(chunk, enc, next) {
// 			data = !data ? chunk : Buffer.concat([data, chunk]);
// 			next();
// 		},
// 		final() {
// 			console.log(data);
// 		},
// 	});
// 	return ws;
// }

// const rs = createReadableStream([1, 2, 3, 4, 5, 6, 7]);
// const ws = createWritableStream();

// rs.pipe(ws);
//#endregion

const zips = zlib.createGzip();

function createUppercaseStream() {
	const ts = stream.Transform({
		transform(chunk, enc, next) {
			chunk = Buffer.from(chunk.toString().toUpperCase());
			next(null, chunk);
		},
	});
	return ts;
}

const us = createUppercaseStream();

http
	.createServer(function (req, res) {
		const pathURL = url.parse(req.url).pathname;
		const pathFile = path.resolve(__dirname, './text.txt');

		if (pathURL === '/') {
			const rs = fs.createReadStream(path.resolve(__dirname, './text.txt'), {
				highWaterMark: 10,
			});
			rs.pipe(us).pipe(zips).pipe(res);
			rs.on('data', (chunk) => {
				console.log(chunk);
			});
			// fs.readFile(pathFile, { encoding: 'utf-8' }, (err, content) => {
			// 	res.end(content.toUpperCase());
			// });
		} else if (pathURL === '/test') {
			res.end('end');
		}
	})
	.listen(config.port);
