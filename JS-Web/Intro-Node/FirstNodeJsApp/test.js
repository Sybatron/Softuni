const config = require('./config.json');
const http = require('http');
const fs = require('fs');
const url = require('url');
const path = require('path');

http
	.createServer(function (req, res) {
		const pathURL = url.parse(req.url).pathname;
		const pathFile = path.resolve(__dirname, './text.txt');

		if (pathURL === '/') {
			fs.readFile(pathFile, { encoding: 'utf-8' }, (err, content) => {
				res.end(content.toUpperCase());
			});
		} else if (pathURL === '/test') {
			res.end('end');
		}
	})
	.listen(config.port);
