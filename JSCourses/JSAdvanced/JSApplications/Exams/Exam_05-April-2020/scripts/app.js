import { createFormEntity } from './firebase-helpers.js';

async function applyCommon() {
	this.partials = {
		header: await this.load('./templates/common/header.hbs'),
		footer: await this.load('./templates/common/footer.hbs'),
	};
	// this.username = sessionStorage.getItem('username');
	this.loggedIn = !!sessionStorage.getItem('token');
}

// initialize the application
async function homeViewHandler() {
	// this.partials.loginPage = await loginViewHandler.call(this);
	await applyCommon.call(this);
	this.partials = {
		// loginPage: loginHandler.call(this),
		// articlesPage: await this.load('./templates/articles/articlesPage.hbs'),
		createPage: await this.load('./templates/create/createPage.hbs'),
		editPage: await this.load('./templates/edit/editPage.hbs'),
		detailPage: await this.load('./templates/details/detailsPage.hbs'),
	};
	// createViewHandler.call(this.partials.createPage);
	this.partial('./templates/home/home.hbs');
}

async function loginHandler() {
	await applyCommon.call(this);
	this.partials.loginForm = await this.load('./templates/login/loginForm.hbs');
	await this.partial('./templates/login/loginPage.hbs');
	// let formRef=document.querySelector
	let formRef = document.querySelector('div.container.auth form');
	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		console.log(e);
		let form = createFormEntity(formRef, ['email', 'login-pass']);
		let formValue = form.getValue();
		firebase
			.auth()
			.signInWithEmailAndPassword(formValue.email, formValue['login-pass'])
			.then((response) => {
				firebase
					.auth()
					.currentUser.getIdToken()
					.then((token) => {
						sessionStorage.setItem('token', token);
						sessionStorage.setItem('email', response.user.email);
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
	this.partials.registerForm = await this.load(
		'./templates/register/registerForm.hbs'
	);
	await this.partial('./templates/register/registerPage.hbs');

	let formRef = document.querySelector('div.container.auth form');

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		let form = createFormEntity(formRef, ['email', 'password', 'rep-pass']);
		let formValue = form.getValue();

		if (formValue.password !== formValue['rep-pass']) {
			return;
		}

		firebase
			.auth()
			.createUserWithEmailAndPassword(formValue.email, formValue.password)
			.then((response) => {
				firebase
					.auth()
					.currentUser.getIdToken()
					.then((token) => {
						sessionStorage.setItem('token', token);
						sessionStorage.setItem('email', response.user.email);
						this.redirect('#/home');
					});
			});
	});
}

async function articlesViewHandler() {
	this.partials.articleContent = await this.load(
		'./templates/articles/articleContent.hbs'
	);
	await this.partial('./templates/articles/articlesPage.hbs');
}

async function createViewHandler() {
	this.partials.createForm = await this.load(
		'./templates/create/createForm.hbs'
	);
}
async function createHandler() {
	console.log('create');
}

async function editViewHandler() {
	this.partials.editForm = await this.load('./templates/edit/editForm.hbs');
	await this.partial('./templates/edit/editPage.hbs');
}

async function detailViewHandler() {
	await this.partial('./templates/details/detailsPage.hbs');
}

async function logoutHandler() {
	await firebase.auth().signOut();
	await sessionStorage.clear(() => {}, 250);
	await this.redirect('#/home');
}

var app = Sammy('#root', function () {
	// include a plugin
	this.use('Handlebars', 'hbs');
	// define a 'route'
	this.get('#/', async function () {
		// load some data
		this.partials = {
			header: await this.load('./templates/common/header.hbs'),
			footer: await this.load('./templates/common/footer.hbs'),
			loginPage: await loginHandler.call(this),
		};
		await this.partial('./templates/home/home.hbs');
	});

	this.get('#/', homeViewHandler);
	this.get('#/home', homeViewHandler);
	this.get('#/login', loginHandler);
	this.get('#/register', registerViewHandler);
	this.post('#/register', () => false);
	this.get('#/create', createViewHandler);
	this.get('#/logout', logoutHandler);
});

app.run('#/');
(() => {
	app.run('#/');
})();
