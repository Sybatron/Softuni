import { createFormEntity } from './firebase-helpers.js';
import { fireBaseRequestFactory } from './firebase-requests.js';

async function applyCommon() {
	this.partials = {
		header: await this.load('./templates/common/header.hbs'),
	};
	this.username = sessionStorage.getItem('username');
	this.loggedIn = !!sessionStorage.getItem('token');
}

async function loginHandler() {
	await applyCommon.call(this);
	this.partials.loginForm = await this.load('./templates/login/loginForm.hbs');
	await this.partial('./templates/login/loginPage.hbs');

	let formRef = document.querySelector('div.login-form form#form');
	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		let form = createFormEntity(formRef, ['email', 'password']);
		let formValue = form.getValue();
		firebase
			.auth()
			.signInWithEmailAndPassword(formValue.email, formValue.password)
			.then((response) => {
				firebase
					.auth()
					.currentUser.getIdToken()
					.then((token) => {
						sessionStorage.setItem('token', token);
						sessionStorage.setItem('username', response.user.email);
						this.redirect('#/');
					});
			})
			.catch(function (error) {
				// Handle Errors here.
				var errorCode = error.code;
				var errorMessage = error.message;
				// ...
			});
	});
}
async function registerHandler() {
	await applyCommon.call(this);
	this.partials.registerForm = await this.load(
		'./templates/register/registerForm.hbs'
	);
	await this.partial('./templates/register/registerPage.hbs');

	let formRef = document.querySelector('div.register-form form#form');

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();
		let form = createFormEntity(formRef, [
			'email',
			'password',
			'repeatPassword',
		]);
		let formValue = form.getValue();

		if (formValue.password !== formValue.repeatPassword) {
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
						this.redirect('#/login');
					});
			});
	});
}
async function logoutHandler() {
	await firebase.auth().signOut();
	await sessionStorage.clear(() => {}, 250);
	await this.redirect('#/');
}

async function postPage() {
	await applyCommon.call(this);

	let firebaseRequester = fireBaseRequestFactory(
		'https://exam-10april2020.firebaseio.com/',
		'posts',
		sessionStorage.getItem('token')
	);
	let postsInfo = await firebaseRequester.getAll();

	this.partials.post = await this.load('./templates/post/post.hbs');
	this.partials.postForm = await this.load('./templates/create/postForm.hbs');
	await this.partial('./templates/create/postPage.hbs');

	console.log(postsInfo);
	let postSection = document.querySelector('div.posts-row');
	Object.entries(postsInfo).forEach((post) => {
		postSection.innerHTML += `<article class="post" data-id=${post[0]}>
		<h1>${post[1].title}</h1>
		<h2><span>${post[1].category}</span></h2>
		<p>${post[1].content}</p>
		<a id="delete-button">Delete</a>
		<a id="details-button">Details</a>
		<a  id="edit-button">Edit</a>
	</article>`;
	});

	let articlesDeleteButtons = document.querySelectorAll(
		'article.post a#delete-button'
	);
	articlesDeleteButtons.forEach((button) => {
		button.addEventListener('click', async () => {
			let id = button.parentNode.dataset.id;
			await firebaseRequester.deleteEntity(id).then((x) => console.log(x));
			setTimeout(() => {
				this.redirect('#/');
			}, 250);
		});
	});

	let formRef = document.querySelector('section.first-section form');

	formRef.addEventListener('submit', async (e) => {
		e.preventDefault();
		console.log(e);
		let form = createFormEntity(formRef, ['title', 'category', 'content']);
		let formValue = form.getValue();

		let post = {
			title: formValue.title,
			category: formValue.category,
			content: formValue.content,
		};

		await firebaseRequester.createEntity(post);
		await this.redirect('#/');
	});
}

var app = Sammy('#root', function () {
	// include a plugin
	this.use('Handlebars', 'hbs');
	// define a 'route'
	this.get('#/', async function () {
		this.partials = {
			header: await this.load('./templates/common/header.hbs'),
			postPage: await postPage.call(this),
		};
		await this.partial('./templates/home/home.hbs');
	});

	this.get('#/login', loginHandler);
	this.get('#/register', registerHandler);
	this.post('#/register', () => false);
	this.get('#/logout', logoutHandler);

	this.get('#/create-post', createPostHandler);
});

app.run('#/');
(() => {
	let tempDiv = document.querySelector('div.to-Delete');
	tempDiv.remove();
	app.run('#/');
})();
