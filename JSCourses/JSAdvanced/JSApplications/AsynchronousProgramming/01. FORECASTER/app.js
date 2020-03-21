function attachEvents() {
	const BASE_URL = 'https://judgetests.firebaseio.com/locations.json';
	const WEATHER_URL =
		'https://judgetests.firebaseio.com/forecast/{status}/{code}.json';

	let elements = {
		locationInput       : document.querySelector('#location'),
		button              : document.querySelector('#submit'),
		notificationHeading : document.querySelector('h1.notification'),
		forecastArea        : document.querySelector('#forecast'),
		currentDiv          : document.querySelector('#current'),
		upcomingDiv         : document.querySelector('#upcoming')
	};
	const weatherSymbols = {
		S : '☀',
		P : '⛅',
		O : '☁',
		R : '☂',
		D : '°'
	};
	const errorHandler = (e) => {
		console.dir(e);
		elements.notificationHeading.innerHTML = e.message;
	};
	const jsonMiddleware = (r) => r.json();

	elements.button.addEventListener('click', getLocationValue);

	function getLocationValue() {
		const location = elements.locationInput.value;

		fetch(BASE_URL)
			.then(jsonMiddleware)
			.then((data) => {
				const { name, code } = data.find(
					(obj) => obj.name === location
				);

				const CURRENT_TODAY_URL = WEATHER_URL.replace(
					'{status}/{code}',
					`today/${code}`
				);
				const TODAY_UPCOMING_URL = WEATHER_URL.replace(
					'{status}/{code}',
					`upcoming/${code}`
				);

				Promise.all([
					fetch(CURRENT_TODAY_URL).then(jsonMiddleware),
					fetch(TODAY_UPCOMING_URL).then(jsonMiddleware)
				])
					.then(showWeatherLocation)
					.then((elements.forecastArea.style = 'display:visible'))
					.catch(errorHandler);
			})
			.catch(errorHandler);
	}
	function showWeatherLocation([ todayData, upcomingData ]) {
		console.log(todayData);
		const { condition, high, low } = todayData.forecast;

		let forecastsDiv = createHTMLElement('div', [ 'forecasts' ]);
		let symbolSpan = createHTMLElement(
			'span',
			[ 'condition', 'symbol' ],
			weatherSymbols[condition[0]]
		);
		let conditionSpan = createHTMLElement('span', [ 'condition' ]);

		let forecastFirstDataSpan = createHTMLElement(
			'span',
			[ 'forecast-data' ],
			todayData.name
		);

		let degreeInfo = `${low}${weatherSymbols.D}/${high}${weatherSymbols.D}`;

		let forecastSecondDataSpan = createHTMLElement(
			'span',
			[ 'forecast-data' ],
			degreeInfo
		);
		let forecastThirdDataSpan = createHTMLElement(
			'span',
			[ 'forecast-data' ],
			condition
		);

		conditionSpan.appendChild(forecastFirstDataSpan);
		conditionSpan.appendChild(forecastSecondDataSpan);
		conditionSpan.appendChild(forecastThirdDataSpan);

		forecastsDiv.appendChild(symbolSpan);
		forecastsDiv.appendChild(conditionSpan);

		elements.currentDiv.appendChild(forecastsDiv);

		showUpcomingWeatherLocation(upcomingData);
	}

	function showUpcomingWeatherLocation({ forecast, name }) {
		let forecastInfoDiv = createHTMLElement('div', [ 'forecast-info' ]);

		forecast.forEach(({ condition, high, low }) => {
			let upcomingSpan = createHTMLElement('span', [ 'upcoming' ], name);
			let degreeInfo = `${low}${weatherSymbols.D}/${high}${weatherSymbols.D}`;

			let symbolSpan = createHTMLElement(
				'span',
				[ 'symbol' ],
				weatherSymbols[condition[0]]
			);
			let degreeSpan = createHTMLElement(
				'span',
				[ 'forecast-data' ],
				degreeInfo
			);
			let conditionSpan = createHTMLElement(
				'span',
				[ 'forecast-data' ],
				condition
			);

			upcomingSpan.appendChild(symbolSpan);
			upcomingSpan.appendChild(degreeSpan);
			upcomingSpan.appendChild(conditionSpan);

			forecastInfoDiv.appendChild(upcomingSpan);
		});

		elements.upcomingDiv.appendChild(forecastInfoDiv);
	}

	function createHTMLElement(tagName, classNames, textContent) {
		let element = document.createElement(tagName);
		if (classNames) {
			element.classList.add(...classNames);
		}
		if (textContent) {
			element.textContent = textContent;
		}

		return element;
	}
}

attachEvents();
