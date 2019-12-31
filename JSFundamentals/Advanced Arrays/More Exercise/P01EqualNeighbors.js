function equalNeighbors(array) {
    let count = 0;

    if (array.length != 1) {
        for (let col = 0; col < array[0].length; col++) {
            if (array[0][col] == array[array.length - 1][col]) {
                count++;
            }

        }
    }


        for (let row = 0; row < array.length - 1; row++) {
            for (let col = 0; col < array[row].length; col++) {
                if (array[row][col] == array[row + 1][col]) {
                    count++;
                }
            }
        }
    

    console.log(count);
}

equalNeighbors(
    [
        [2, 2, 5, 7, 4]
    ]
);