function garageInfo(carsInput) {
    class Garage {
        garages = [];
        cars = [];
    };

    let garageStorage= new Garage();

    class Car {
        garage = 0;
        color = '';
        fuelType = '';
        manufacture = '';
    }


    carsInput.forEach(element => {
        const garageNum = Number(element[0]);
        const matches = element
            .matchAll(/(?<Prop>(?:\w{1,} {0,1}){1,}): (?<Value>(\w{1,} {0,1}){1,})/);

        let car = new Car();
        for (const match of matches) {

            garageStorage.garages.push(garageNum);
            car.garage = garageNum;
            let value = match.groups['Value'];
            switch (match.groups['Prop']) {
                case 'color':
                    car.color = value;
                    break;
                case 'fuel type':
                    car.fuelType = value;
                    break;
                case 'manufacture':
                    car.manufacture = value;
                    break;
            }
        }

        garageStorage.cars.push(car);
    });

    garageStorage.garages= new Set(garageStorage.garages.values);

    for (let i = 0; i < garageStorage.garages.length; i++) {
        const garageNum = garageStorage.garages[i];

        if (garageNum) {
            console.log(`Garage № ${garageNum+1}`);
        } else {
            continue;
        }

    }
}

garageInfo(['1 - color: blue, fuel type: diesel',
    '1 - color: red, manufacture: Audi',
    '2 - fuel type: petrol',
    '4 - color: dark blue, fuel type: diesel, manufacture: Fiat'
]);