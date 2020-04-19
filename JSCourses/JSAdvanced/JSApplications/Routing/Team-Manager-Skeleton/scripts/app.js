import { createFormEntity } from './firebase-helpers.js';

async function applyCommon() {
	this.partials = {
		header: await this.load('./templates/common/header.hbs'),
		footer: await this.load('./templates/common/footer.hbs'),
	};
	this.username = sessionStorage.getItem('username');
	this.loggedIn = !!sessionStorage.getItem('token');
	this.hasNoTeam = true;
}

// initialize the application
async function homeViewHandler() {
	await applyCommon.call(this);

	this.partial('./templates/home/home.hbs');
}

async function aboutViewHandler() {
	this.partials = {
		header: await this.load('./templates/common/header.hbs'),
		footer: await this.load('./templates/common/footer.hbs'),
	};
	this.partial('./templates/about/about.hbs');
}

async function loginViewHandler() {
	await applyCommon.call(this);
	(this.partials.loginForm = await this.load(
		'./templates/login/loginForm.hbs'
	)),
		await this.partial('./templates/login/loginPage.hbs');

	let formRef = document.querySelector('#login-form');
	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		let form = createFormEntity(formRef, ['username', 'password']);
		let formValue = form.getValue();
		firebase
			.auth()
			.signInWithEmailAndPassword(formValue.username, formValue.password)
			.then((response) => {
				firebase
					.auth()
					.currentUser.getIdToken()
					.then((token) => {
						sessionStorage.setItem('token', token);
						sessionStorage.setItem('username', response.user.email);
						this.redirect('#/home');
					});

				this.redirect('#/home');
			})
			.catch(function (error) {
				// Handle Errors here.
				var errorCode = error.code;
				var errorMessage = error.message;
				// ...
			});
	});
}

async function registerViewHandler() {
	await applyCommon.call(this);
	(this.partials.registerForm = await this.load(
		'./templates/register/registerForm.hbs'
	)),
		await this.partial('./templates/register/registerPage.hbs');

	let formRef = document.querySelector('#register-form');

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		let form = createFormEntity(formRef, [
			'username',
			'password',
			'repeatPassword',
		]);
		let formValue = form.getValue();

		if (formValue.password !== formValue.repeatPassword) {
			return;
		}

		firebase
			.auth()
			.createUserWithEmailAndPassword(formValue.username, formValue.password)
			.then((response) => {
				firebase
					.auth()
					.currentUser.getIdToken()
					.then((token) => {
						sessionStorage.setItem('token', token);
						sessionStorage.setItem('username', response.user.email);
						this.redirect('#/home');
					});
			});
	});
}

async function catalogHandler() {
	await applyCommon.call(this);

	this.partial('./templates/catalog/teamCatalog.hbs');

	let token = sessionStorage.getItem('token');

	fetch('https://routing-2015b.firebaseio.com/.json?auth=' + token)
		.then((x) => x.json())
		.then((res) => console.log(res));
}

async function createTeamHandler() {
	await applyCommon.call(this);
	this.partials.createForm = await this.load(
		'./templates/create/createForm.hbs'
	);
	this.partial('./template/create/createPage.hbs');

	let formRef = document.querySelector('#create-form');

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();

		let form = createFormEntity(formRef, ['name', 'content']);
		let formValue = form.getValue();
	});
}

function logoutHandler() {
	sessionStorage.clear();
	firebase.auth().signOut();
	this.redirect('#/home');
}

var app = Sammy('#main', function () {
	// include a plugin
	this.use('Handlebars', 'hbs');

	// define a 'route'
	this.get('#/', async function () {
		// load some data
		this.partials = {
			header: await this.load('./templates/common/header.hbs'),
			footer: await this.load('./templates/common/footer.hbs'),
		};
		this.partial('./templates/home/home.hbs');
	});

	this.get('#/', homeViewHandler);
	this.get('#/home', homeViewHandler);
	this.get('#/about', aboutViewHandler);
	this.get('#/login', loginViewHandler);
	this.get('#/register', registerViewHandler);
	this.post('#/register', () => false);
	this.get('#/logout', logoutHandler);
	this.get('#/catalog', catalogHandler);
	this.get('#/createTeam', createTeamHandler);
});

// start the application
app.run('#/');

// TODO
(() => {
	app.run('#/');
})();
