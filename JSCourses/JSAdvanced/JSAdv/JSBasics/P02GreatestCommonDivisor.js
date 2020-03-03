function gcd(num1, num2) {
    let smallerNum = Math.min(num1, num2);
    let gcdNum = 1;
    if (num1 % smallerNum === 0 && num2 % smallerNum === 0) {
        return smallerNum;
    }

    for (let i = 2; i < smallerNum / 2; i++) {
        if (num1 % i === 0 && num2 % i === 0) {
            gcdNum = i;
        }
    }

    return gcdNum;
}

console.log(gcd(15, 5));