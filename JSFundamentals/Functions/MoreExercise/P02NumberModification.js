function modifyNum(num) {
    function sumDigits(num) {
        let sum = 0;
        let length = num.toString().length;
        for (let i = 0; i < length; i++) {
            sum += num % 10;
            num = Number.parseInt(num / 10);
        }
    
        return sum;
    }
    
    let length = num.toString().length;
    let sumOfDigits = sumDigits(num);
    let curentNum = num;

    while (!(sumOfDigits / length > 5)) {
        length++;
        sumOfDigits += 9;
        curentNum = curentNum * 10 + 9 ;
    }

    console.log(curentNum);
}



modifyNum(101);