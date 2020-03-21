function attachEvents() {
	const elements = {
		anglerInput      : document.querySelector('#addForm input.angler'),
		weightInput      : document.querySelector('#addForm input.weight'),
		speciesInput     : document.querySelector('#addForm input.species'),
		locationInput    : document.querySelector('#addForm input.location'),
		baitInput        : document.querySelector('#addForm input.bait'),
		captureTimeInput : document.querySelector('#addForm input.captureTime'),
		addBtn           : document.querySelector('#addForm button.add')
	};

	const CREATE_URL = 'https://fisher-game.firebaseio.com/catches.json';

	elements.addBtn.addEventListener('click', addCatch);

	async function addCatch() {
		let myCatch = {
			angler      : elements.anglerInput.vale,
			weight      : elements.weightInput.vale,
			species     : elements.speciesInput.vale,
			location    : elements.locationInput.vale,
			bait        : elements.baitInput.vale,
			captureTime : elements.captureTimeInput.vale
		};

		const options = {
			headers : {
				'Content-Type' : 'application/json'
			},
			body    : JSON.stringify(myCatch),
			method  : 'POST'
		};

		const response = await fetch(CREATE_URL, options);
		const data = await response.json();
		console.log(data);
	}
}

attachEvents();
