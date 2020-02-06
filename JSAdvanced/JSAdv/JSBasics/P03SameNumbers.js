function sameNumbers(number) {
    let numAsText = number.toString();
    let digitAsText = numAsText[0];
    let areSame = true;
    for (let i = 1; i < numAsText.length; i++) {
        if (numAsText[i] !== digitAsText) {
            areSame = false;
            break;
        }
    }

    let digit = Number(digitAsText);

    console.log(areSame);
    if (areSame) {
        console.log(numAsText.length * digit);
    } else {
        let sum = 0;

        for (let i = 0; i < numAsText.length; i++) {
            sum += Number(numAsText[i]);
        }

        console.log(sum);
    }
}

sameNumbers(1234);