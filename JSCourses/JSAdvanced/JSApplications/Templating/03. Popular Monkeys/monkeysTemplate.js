import { monkeys } from './monkeys.js';

(async () => {
	Handlebars.registerPartial(
		'monkey',
		await fetch('./monkey-template.hbs').then(r => r.text())
	);

	let templateSrc = await fetch('./all-monkeys-template.hbs').then(r =>
		r.text()
	);
	let template = Handlebars.compile(templateSrc);

	const resultHTML = template({ monkeys });
	document.querySelector('section').innerHTML = resultHTML;

	let buttons = document.querySelectorAll('button');
	buttons.forEach(btn => {
		btn.addEventListener('click', () => {
			let parent = btn.parentNode;
			let tempP = parent.querySelector('p');
			let { display } = tempP.style;

			if (display === 'none') {
				tempP.style.display = 'block';
				btn.textContent = 'Hide info';
			} else {
				tempP.style.display = 'none';
				btn.textContent = 'Info';
			}
		});
	});
})();
