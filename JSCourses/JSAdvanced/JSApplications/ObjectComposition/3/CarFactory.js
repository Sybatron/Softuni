function createCar(car) {
	let engines = [
		(SmallEngine = {
			power: 90,
			volume: 1800
		}),
		(NormalEngine = {
			power: 120,
			volume: 2400
		}),
		(MonsterEngine = {
			power: 200,
			volume: 3500
		})
	];
	let engineIndex = 0;
	if (car.power <= engines[0].power) {
		engineIndex = 0;
	} else if (car.power <= engines[1].power) {
		engineIndex = 1;
	} else {
		engineIndex = 2;
	}

	let carriages = [
		(Hatchback = {
			type: 'hatchback',
			color: ''
		}),
		(Coupe = {
			type: 'coupe',
			color: ''
		})
	];
	let carriegeIndex = 0;
	if (car.carriage === carriages[1].type) {
		carriegeIndex = 1;
	}

	carriages[carriegeIndex].color = car.color;

	let wheels = [ 1, 2, 3, 4 ];
	if (car.wheelsize % 2 === 0) {
		car.wheelsize--;
	}
	wheels.fill(car.wheelsize, 0, 4);

	newCar = {
		model: car.model,
		engine: engines[engineIndex],
		carriage: carriages[carriegeIndex],
		wheels: wheels
	};

	return newCar;
}
console.log(
	createCar({
		model: 'Opel Vectra',
		power: 110,
		color: 'grey',
		carriage: 'coupe',
		wheelsize: 17
	})
);

function createCarV2({ model, power, color, carriage, wheelsize }) {
	let engines = [ { power: 90, volume: 1800 }, { power: 120, volume: 2400 }, { power: 200, volume: 3500 } ];

	newCar = {
		model,
		engine: engines.find((p) => power <= p.power),
		carriage: { type: carriage, color },
		wheels: Array(4).fill(wheelsize % 2 === 0 ? wheelsize - 1 : wheelsize)
	};

	return newCar;
}

console.log(
	createCarV2({
		model: 'Opel Vectra',
		power: 110,
		color: 'grey',
		carriage: 'coupe',
		wheelsize: 17
	})
);
