function isMagicMatrix(matrix) {
    let sum = 0;
    for (let i = 0; i < matrix[0].length; i++) {
        sum += matrix[0][i];
    }

    for (let row = 1; row < matrix.length; row++) {
        let tempSum = 0;
        for (let col = 0; col < matrix[row].length; col++) {
            tempSum += matrix[row][col];
        }
        if (tempSum !== sum) {
            return false;
        }
    }

    for (let col = 0; col < matrix[0].length; col++) {
        let tempSum = 0;
        for (let row = 0; row < matrix.length; row++) {
            tempSum += matrix[row][col];
        }
        if (tempSum !== sum) {
            return false;
        }
    }

    return true;
}

console.log(isMagicMatrix([
    [4, 5, 6],
    [6, 5, 4],
    [5, 5, 5]
]));