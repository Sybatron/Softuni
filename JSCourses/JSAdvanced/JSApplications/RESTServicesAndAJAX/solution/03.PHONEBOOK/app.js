function attachEvents() {
	let loadBtnRef = document.querySelector('#btnLoad');
	let createBtnRef = document.querySelector('#btnCreate');

	let phonebookRef = document.querySelector('#phonebook');

	let newPersonValue = document.querySelector('#person');
	let newPhoneValue = document.querySelector('#phone');
	let nextElementId;

	let phonePattern = /^(\d{3})([-\s]{0,1}\d{3}){2}\d$/;

	fetch('https://phonebook-nakov.firebaseio.com/phonebook.json')
		.then((x) => x.json())
		.then((x) => console.log(x));

	function getAllPhones() {
		return fetch('https://phonebook-nakov.firebaseio.com/phonebook.json')
			.then((x) => x.json())
			.then((users) =>
				Object.entries(users).filter(
					(x) => !!x[1].person && !!x[1].phone
				)
			);
	}

	loadBtnRef.addEventListener('click', () => {
		loadAllPhones();
	});

	createBtnRef.addEventListener('click', () => {
		if (!newPersonValue.value || !newPhoneValue.value) {
			alert('Blank input data!');
			return;
		}
		if (!phonePattern.exec(newPhoneValue.value)) {
			alert(
				'The phone number is not in format: xxx-xxx-xxxx or xxx xxx xxxx or xxxxxxxxxx'
			);
			return;
		}

		let newPerson = {
			person : newPersonValue.value,
			phone  : newPhoneValue.value
		};
		getAllPhones().then((currentPhoneCollection) => {
			let nextId;
			if (!currentPhoneCollection[currentPhoneCollection.length - 2]) {
				nextId = 1;
			} else {
				nextId =
					parseInt(
						currentPhoneCollection[
							currentPhoneCollection.length - 2
						][0]
					) + 1;
			}
			fetch(
				`https://phonebook-nakov.firebaseio.com/phonebook/${nextId}.json`,
				{
					method : 'PUT',
					body   : JSON.stringify(newPerson)
				}
			)
				.then(() => {
					newPersonValue.value = '';
					newPhoneValue.value = '';
					loadAllPhones();
				})
				.catch((err) => {
					console.log(err, ' <err');
				});
		});
	});

	function loadAllPhones() {
		getAllPhones().then((usersToBeDisplayed) => {
			nextElementId = usersToBeDisplayed.length + 1;
			phonebookRef.innerHTML = '';
			usersToBeDisplayed.forEach((user) => {
				let li = document.createElement('li');
				li.innerHTML = `${user[1].person}: ${user[1].phone}`;
				li.id = 'phonebook';

				let deleteBtn = document.createElement('button');
				deleteBtn.innerHTML = 'Delete';
				deleteBtn.addEventListener('click', () => {
					fetch(
						`https://phonebook-nakov.firebaseio.com/phonebook/${user[0]}.json`,
						{
							method : 'DELETE'
						}
					).then(loadAllPhones);
				});

				li.appendChild(deleteBtn);

				phonebookRef.appendChild(li);
			});
		});
	}
}

attachEvents();
