function getInfo() {
	let stopInputValue = document.querySelector('#stopId').value.trim();
	let stopNameRef = document.querySelector('#stopName');
	let stopBusesList = document.querySelector('#buses');
	fetch(`https://judgetests.firebaseio.com/businfo/${stopInputValue}.json`).then((x) => x.json()).then((x) => {
		stopBusesList.innerHTML = '';
		if (!x.error) {
			stopNameRef.innerHTML = x.name;
			Object.entries(x.buses).forEach(([ busId, time ]) => {
				let li = document.createElement('li');
				li.innerHTML = `Bus ${busId} arrives in ${time}`;
				stopBusesList.appendChild(li);
			});
		} else {
			stopNameRef.innerHTML = 'Error';
		}
	});
}
