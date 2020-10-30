const config = require('./config.json');
const http = require('http');
const fs = require('fs');
const url = require('url');
const path = require('path');
const querystring = require('querystring');

const VIEWS_PATH = path.resolve(__dirname, config.viewDir);

const routeMap = {
	'/': '/home/index.html',
	'/addBreed': 'addBreed.html',
	'/addCat': 'addCat.html',
};

const mimeTypeMap = {
	'.html': 'text/html',
	'.css': 'text/css',
	'.js': 'application/javascript',
	'.json': 'application/json',
};

function sendFile(res, fullFilePath) {
	fs.readFile(fullFilePath, function (err, data) {
		const type = path.extname(fullFilePath);
		if (err) {
			const { message } = err;
			res
				.writeHead(500, {
					'Content-Length': Buffer.byteLength(data),
					'Content-Type': 'text/plain',
				})
				.end(message);
			return;
		}
		res
			.writeHead(200, {
				'Content-Length': Buffer.byteLength(data),
				'Content-Type': mimeTypeMap[type] || 'text/plain',
			})
			.end(data);
	});
}

function httpHandler(req, res) {
	const filePath = url.parse(req.url).pathname;
	const method = req.method.toUpperCase;
	if (method === 'GET') {
		if (filePath.includes(`${config.staticFileDir}/`)) {
			const fullStaticFilePath = path.resolve(__dirname, filePath.slice(1));
			sendFile(res, fullStaticFilePath);
			return;
		}

		const relativeFilePath = routeMap[filePath];

		if (!relativeFilePath) {
			const data = 'Not Found';
			res
				.writeHead(404, {
					'Content-Length': Buffer.byteLength(data),
					'Content-Type': 'text/plain',
				})
				.end(data);
			return;
		}

		const fullFilePath = path.join(VIEWS_PATH, relativeFilePath);
		sendFile(res, fullFilePath);
	} else if (method === 'POST') {
		res.write(query.breed);
	}
}

http.createServer(httpHandler).listen(config.port, () => {
	console.log(`Server is listening to ${config.port}`);
});
