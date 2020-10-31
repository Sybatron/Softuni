const exprss = require('./exprss');

const app = exprss();

function logRequestDat(req, res, next) {
	console.log(Date.now());
	next();
}

function bodyParser(req, res, next) {
	let data;
	req.on('data', function (chunk) {
		data = data ? Buffer.concat(data, chunk) : chunk;
	});
	req.on('end', function () {
		const body = JSON.parse(data.toString());
		req.body = body;
		next();
	});
}

app.get('/', logRequestDat, (req, res) => {
	res.end('Hello world!');
});

app.post('/', bodyParser, (req, res) => {
	console.log(req.body);
	res.end(req.body);
});

app.listen(3000, function () {
	console.log('EXPRSS is listening to: 3000');
});
