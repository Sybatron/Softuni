const express = require('express');
const path = require('path');
const handlebars = require('express-handlebars');

const app = express();

app.engine(
	'.hbs',
	handlebars({
		extname: '.hbs',
	})
);
app.set('view engine', '.hbs');
app.set('views', path.resolve(__dirname, './views'));

//#region
// function logRequestData(req, res, next) {
// 	console.log(new Date());
// 	setTimeout(function () {
// 		next();
// 	}, 3000);
// }

// app.use(logRequestData);

// app.get('/', (req, res) => {
// 	res.end('Hi world');
// });

// app.get('/', (req, res) => {
// 	res.sendFile(path.resolve(__dirname, './index.html'));
// });
//#endregion

const jsonBodyParser = express.json();
const urlencodedBodyParser = express.urlencoded({ extended: true });

const users = [
	{ name: 'Ivan', age: 20 },
	{ name: 'Gosho', age: 30 },
];

app.use(jsonBodyParser);
app.use(urlencodedBodyParser);
// app.use('/static/', express.static(path.resolve(__dirname, './static')));

app.get('/', function (req, res) {
	res.render('home', { users });
});
app.get('/about', function (req, res) {
	res.render('about', { 'par-text': 'Send email --here--' });
});

app.get('/user/:idx', function (req, res) {
	const selectedUser = users[req.params.idx];
	res.render('home', {
		users,
		selectedUser,
		selectedUserIndex: req.params.idx,
	});
});

app.post('/user/:idx', function (req, res) {
	const { name, age } = req.body;
	users[req.params.idx] = { name, age: +age };
	res.redirect('/');
});

app.post('/user', function (req, res) {
	const { name, age } = req.body;
	users.push({ name, age: +age });
	res.redirect('/');
});

// app.post('/', function (req, res) {
// 	console.log(req.body);
// 	res.json(req.body);
// });

app.listen(3000, () => {
	console.log('App is listening to: 3000');
});
