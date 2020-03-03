function printArr(arr) {
    let delimiter = arr.pop();
    console.log(arr.join(delimiter));
}

printArr(['One',
    'Two',
    'Three',
    'Four',
    'Five',
    '-'
]);