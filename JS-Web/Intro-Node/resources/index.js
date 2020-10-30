const config = require('./config.json');
const http = require('http');
const fs = require('fs');
const url = require('url');

http
	.createServer((req, res) => {
		res.write('Hello world!');
		res.end();
	})
	.listen(config.port);
