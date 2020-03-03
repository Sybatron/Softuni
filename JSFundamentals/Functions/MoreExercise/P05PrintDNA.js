function printDna(rows) {
    let printRow = function (num, letter1, letter2) {
        switch (num) {
            case 1:
                console.log(`**${letter1+letter2}**`);
                break;
            case 2:
                console.log(`*${letter1}--${letter2}*`);
                break;
            case 3:
                console.log(`${letter1}----${letter2}`);
                break;
            case 4:
                console.log(`*${letter1}--${letter2}*`);
                break;
            case 5:
                console.log(`**${letter1+letter2}**`);
                break;
        }
    }

    let row = 1;
    let i = -1;
    let text = 'ATCGTTAGGG';

    while (rows > 0) {
        printRow(row, text[++i], text[++i]);

        row++;
        if (row > 5) {
            row = 2;
        }
        if (i == text.length - 1) {
            i = -1;
        }

        rows--;
    }
}