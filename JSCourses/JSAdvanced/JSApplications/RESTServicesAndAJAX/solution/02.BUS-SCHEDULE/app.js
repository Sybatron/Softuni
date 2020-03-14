function solve() {
	let connectionRef = document.querySelector('.info');
	let currentStopName = '';
	let nextStopId = '';
	let departActionRef = document.querySelector('#depart');
	let arriveActionRef = document.querySelector('#arrive');

	fetch(`https://judgetests.firebaseio.com/schedule.json`)
		.then((x) => x.json())
		.then((x) => console.log(x));

	function getScheduleById(id) {
		let requestedId = id;
		if (!id) {
			requestedId = 'depot';
		}
		return fetch(
			`https://judgetests.firebaseio.com/schedule/${requestedId}.json`
		);
	}

	function setStateToTravelling() {
		departActionRef.disabled = true;
		arriveActionRef.disabled = false;
	}

	function setStateToIdle() {
		departActionRef.disabled = false;
		arriveActionRef.disabled = true;
	}

	function setNextStop(stopName) {
		connectionRef.innerHTML = `Next stop ${stopName}`;
	}

	function setArriving(stopName) {
		connectionRef.innerHTML = `Arriving at ${stopName}`;
	}

	function depart() {
		getScheduleById(nextStopId).then((x) => x.json()).then((x) => {
			nextStopId = x.next;
			currentStopName = x.name;
			setNextStop(currentStopName);
			setStateToTravelling();
		});
	}

	function arrive() {
		getScheduleById(nextStopId).then((x) => x.json()).then((x) => {
			setArriving(currentStopName);
			setStateToIdle();
		});
	}

	return {
		depart,
		arrive
	};
}

let result = solve();
