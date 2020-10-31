const { json } = require('express');
const http = require('http');
const url = require('url');

function methodHandlerFactory(handlers, method) {
	return function (path, ...fns) {
		handlers[method][path] = fns;
	};
}

function iterateAndExecHandler(req, res, handlersArr) {
	const fn = handlersArr[0];
	if (!fn) {
		done(req, res);
		return;
	}
	fn(req, res, function (err) {
		iterateAndExecHandler(req, res, handlersArr.slice(1));
	});
}

module.exports = function () {
	const handlers = {
		get: {},
		post: {},
		delete: {},
		put: {},
	};

	const server = http.createServer((req, res) => {
		const { path, query } = url.parse(req.url, true);
		const method = req.method.toLocaleLowerCase();
		const reqHandlers = handlers[method][path];

		if (!reqHandlers) {
			res.end(`Route ${method} ${path} not found!`);
			return;
		}

		const originalEnd = res.end.bind(res);
		res.end = function (data) {
			if (typeof data === 'object') {
				data = JSON.stringify(data);
			}
			originalEnd(data);
		};
		iterateAndExecHandler(req, res, reqHandlers);
	});

	return {
		listen: server.listen.bind(server),
		get: methodHandlerFactory(handlers, 'get'),
		post: methodHandlerFactory(handlers, 'post'),
	};
};
