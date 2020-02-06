function calorieProducts(arr) {
    let productsInfo = {};

    for (let i = 0; i < arr.length; i += 2) {
        productsInfo[arr[i]] = Number(arr[i + 1]);
    }
    console.log(productsInfo);
}

calorieProducts(['Yoghurt', 48, 'Rise', 138, 'Apple', 52]);