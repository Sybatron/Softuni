function solve(oddCount) {
    let sum = 0;
    let count = 0;
    let i = 1;

    while (count < oddCount) {
        console.log(i);
        sum += i;
        i += 2;
        count++;
    }

    console.log(`Sum: ${sum}`);
}

solve(10);