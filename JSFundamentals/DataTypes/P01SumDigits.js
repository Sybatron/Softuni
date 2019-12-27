function sumDigits(input){
    let num = Number(input);
    let sum = 0;
    
    for (let i = 0; i < input.toString().length; i++) {
        sum += num % 10;
        num /= 10;
        num = Number.parseInt(num);
    }

    console.log(sum);
}

sumDigits(245678);