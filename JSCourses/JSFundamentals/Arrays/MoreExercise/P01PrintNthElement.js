function printNthElement(input) {
    const step = Number(input.pop());
    const newArr=[];

    for (let i = 0; i < input.length; i+=step) {
       newArr.push(input[i]);
    }
    
    console.log(newArr.join(' '));
}

printNthElement(['5', '20', '31', '4', '20', '2']);