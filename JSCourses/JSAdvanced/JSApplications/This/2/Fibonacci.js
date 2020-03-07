function getFibonator() {
    let n1 = 0.5;
    let n2 = 0.5;
    return function getFibbonacciNum() {
        let temp = n1 + n2;
        n1 = parseInt(n2);
        n2 = temp;
        return temp;
    }
}

let fib = getFibonator();
console.log(fib()); // 1
console.log(fib()); // 1
console.log(fib()); // 2
console.log(fib()); // 3
console.log(fib()); // 5
console.log(fib()); // 8
console.log(fib()); // 13