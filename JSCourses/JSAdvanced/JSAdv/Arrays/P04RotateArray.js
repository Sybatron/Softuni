function rotateArray(arr) {
    let n = Number(arr.pop());
    n = n % arr.length ;

    for (let i = 0; i < n; i++) {
        let lastElement = arr.pop();
        arr.unshift(lastElement);
    }

    console.log(arr.join(' '));
}

rotateArray(['1',
    '2',
    '3',
    '4',
    '2'
]);