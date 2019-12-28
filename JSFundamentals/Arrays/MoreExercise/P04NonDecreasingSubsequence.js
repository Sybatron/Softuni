function nonDecreasingSubsequence(arr) {
    let newArr = [arr[0]];
    let biggestNum = arr[0];

    for (let i = 1; i < arr.length; i++) {
        const element = arr[i];

        if (element >= biggestNum) {
            biggestNum = element;
            newArr.push(biggestNum);
        }
    }

    console.log(newArr.join(' '));
}

nonDecreasingSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]);