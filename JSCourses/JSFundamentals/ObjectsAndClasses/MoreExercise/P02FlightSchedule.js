function flightSheduleChange(input) {
    let flights = {
        flightArr: [],
        destinationArr: [],
        statusesArr: [],
    };

    input[0].forEach(element => {
        let info = element.split(' ');
        flights.flightArr.push(info[0]);
        flights.destinationArr.push(info[1]);
        flights.statusesArr.push('Ready to fly');
    });

    input[1].forEach(element => {
        let info = element.split(' ');
        let indexOfFlight = flights
            .flightArr
            .indexOf(info[0]);
        flights.statusesArr[indexOfFlight] = info[1];
    });

    let status = input[2][0];
    let indexOfStatus = flights.statusesArr.indexOf(status);

    while (indexOfStatus != -1) {
        let destination = flights.destinationArr[indexOfStatus];

        console.log(`{ Destination: '${destination}', Status: '${status}' }`);

        indexOfStatus = flights.statusesArr.indexOf(status, indexOfStatus + 1);
    }
}

flightSheduleChange([
    ["WN269 Delaware", "FL2269 Oregon", "WN498 Las vegas", "WN3145 Ohio", "WN612 Alabama", "WN4010 New York", "WN1173 California", "DL2120 Texas", "KL5744 Illinois", "WN678 Pennsylvania"],
    ["DL2120 Cancelled", "WN612 Cancelled", "WN1173 Cancelled", "SK330 Cancelled"],
    ["Ready to fly"]
]);


// flightSheduleChange([
//     ['WN269 Delaware',
//         'FL2269 Oregon',
//         'WN498 Las Vegas',
//         'WN3145 Ohio',
//         'WN612 Alabama',
//         'WN4010 New York',
//         'WN1173 California',
//         'DL2120 Texas',
//         'KL5744 Illinois',
//         'WN678 Pennsylvania'
//     ],

//     ['DL2120 Cancelled',
//         'WN612 Cancelled',
//         'WN1173 Cancelled',
//         'SK430 Cancelled'
//     ],

//     ['Cancelled']
// ]);