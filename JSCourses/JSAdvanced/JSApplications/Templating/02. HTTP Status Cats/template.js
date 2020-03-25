(async () => {
	Handlebars.registerPartial(
		'cat',
		await fetch('./cat-template.hbs').then(r => r.text())
	);

	const template = Handlebars.compile(
		await fetch('./all-cats-template.hbs').then(r => r.text())
	);

	document.querySelector('section#allCats').innerHTML = resultHTML;

	document.querySelectorAll('button').forEach(btn => {
		btn.addEventListener('click', () => {
			let statusDiv = btn.parentNode.querySelector('div.status');

			let { display } = statusDiv.style;

			if (display === 'none') {
				btn.textContent = 'Hide status code';
				statusDiv.style.display = 'block';
			} else {
				btn.textContent = 'Show status code';
				statusDiv.style.display = 'none';
			}
		});
	});
})();
