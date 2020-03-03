function roadRadar(arr) {
    let speed = arr[0];
    let area = arr[1];

    function printIsSpeeding(speed) {
        if (speed > 0) {
            if (speed <= 20) {
                console.log('speeding');
            } else if (speed <= 40) {
                console.log('excessive speeding');
            } else {
                console.log('reckless driving');
            }
        }
    }

    let speedOverLimit;
    switch (area) {
        case 'motorway':
            speedOverLimit = speed - 130;
            printIsSpeeding(speedOverLimit);
            break;
        case 'interstate':
            speedOverLimit = speed - 90;
            printIsSpeeding(speedOverLimit);
            break;
        case 'city':
            speedOverLimit = speed - 50;
            printIsSpeeding(speedOverLimit);
            break;
        case 'residential':
            speedOverLimit = speed - 20;
            printIsSpeeding(speedOverLimit);
            break;
    }
}

roadRadar([21, 'residential']);