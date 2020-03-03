function pointsValidation(points) {
    let x1 = points[0];
    let y1 = points[1];
    let x2 = points[2];
    let y2 = points[3];

    let calculateDistance = function (cord1, cord2) {
        return Math.abs(cord1 - cord2);
    }

    let isPointValid = function (cord1, cord2, cord3, cord4) {
        let x1 = cord1;
        let y1 = cord2;
        let x2 = cord3;
        let y2 = cord4;

        let width = calculateDistance(x1, x2);
        let height = calculateDistance(y1, y2);

        let distance = Math.sqrt(width ** 2 + height ** 2);

        if (Number.isInteger(distance)) {
            return true;
        } else {
            return false;
        }
    }

    let printIsValid = function (x1, y1, x2, y2) {
        if (isPointValid(x1, y1, x2, y2)) {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is valid`);
        } else {
            console.log(`{${x1}, ${y1}} to {${x2}, ${y2}} is invalid`);
        }
    }

    printIsValid(x1, y1, 0, 0);
    printIsValid(x2, y2, 0, 0);
    printIsValid(x1, y1, x2, y2);
}