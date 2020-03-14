function attachEvents() {
	let loadBtnRef = document.querySelector('#btnLoad');
	let createBtnRef = document.querySelector('#btnCreate');

	loadBtnRef.addEventListener('click', () => {
		fetch('https://phonebook-nakov.firebaseio.com/phonebook.json')
			.then((x) => x.json())
			.then((x) => console.log(x));
	});
	console.log('TODO...');
}

attachEvents();
