const URL = 'https://restcountries.eu/rest/v2/all';
fetch(URL)
	.then(r => r.json())
	.then(c => console.log(c));

const elements = {
	loadBtn: document.querySelector('#btnLoadTowns'),
	inputRef: document.querySelector('input'),
	countriesWrapper: document.querySelector('#root')
};
elements.loadBtn.addEventListener('click', () => {
	Promise.all([
		fetch(URL).then(r => r.json()),
		fetch('./template.hbs').then(r => r.text())
	]).then(([countriesData, templateHbs]) => {
		const template = Handlebars.compile(templateHbs);

		let expectedCountries = elements.inputRef.value.split(', ');
		let countries = Object.entries(countriesData).filter(c =>
			expectedCountries.includes(c[1].name)
		);
		countries = countries
			.reduce((acc, value) => {
				acc.push(value[1]);
				return acc;
			}, [])
			.sort((a, b) => a.name.localeCompare(b.name));

		const resultHTML = template({ countries: countries });
		elements.countriesWrapper.innerHTML = resultHTML;
	});
});
