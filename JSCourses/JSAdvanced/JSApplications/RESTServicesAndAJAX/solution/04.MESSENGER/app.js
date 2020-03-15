function attachEvents() {
	fetch('https://rest-messanger.firebaseio.com/messanger.json')
		.then((x) => x.json())
		.then((x) => console.log(x));

	let authorInputRef = document.querySelector('#author');
	let contentInputRef = document.querySelector('#content');

	let messageArea = document.querySelector('#messages');

	let refreshBtn = document.querySelector('#refresh');
	let submitBtn = document.querySelector('#submit');

	function getAllMessages() {
		return fetch('https://rest-messanger.firebaseio.com/messanger.json')
			.then((x) => x.json())
			.then((messages) =>
				Object.entries(messages).filter(
					(x) => !!x[1].author && !!x[1].content
				)
			);
	}

	function refreshAllMessages() {
		getAllMessages().then((messages) => {
			messageArea.innerHTML = '';
			messages.forEach((msg) => {
				messageArea.innerHTML += `${msg[1].author}: ${msg[1]
					.content}\n`;
			});
		});
	}

	refreshBtn.addEventListener('click', () => {
		refreshAllMessages();
	});

	submitBtn.addEventListener('click', () => {
		if (!authorInputRef.value && !contentInputRef.value) {
			alert('Blank input data!');
			return;
		}
		let message = {
			author  : authorInputRef.value,
			content : contentInputRef.value
		};
		fetch('https://rest-messanger.firebaseio.com/messanger.json', {
			method : 'POST',
			body   : JSON.stringify(message)
		})
			.then(() => {
				authorInputRef.value = '';
				contentInputRef.value = '';
				refreshAllMessages();
			})
			.catch((err) => {
				console.log(err, ' <err');
			});
	});
}

attachEvents();

// (function deleteWrong() {
// 	fetch(
// 		`https://rest-messanger.firebaseio.com/messanger/-M2R0Dub8mvELXdFc -
// 			ND.json`,
// 		{
// 			method : 'DELETE'
// 		}
// 	);
// })()
