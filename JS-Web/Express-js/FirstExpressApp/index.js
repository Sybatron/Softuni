const express = require('express');

const app = express();

function logRequestData(req, res, next) {
	console.log(new Date());
	setTimeout(() => {
		next();
	}, 3000);
}

const jsonBodyParser = express.json();

app.use(logRequestData);

app.get('/', (req, res) => {
	res.end('Hi world');
});

app.post('/', jsonBodyParser, function (req, res) {
	console.log(req.body);
	res.send(req.body);
});

app.listen(3000, () => {
	console.log('App is listening to: 3000');
});
