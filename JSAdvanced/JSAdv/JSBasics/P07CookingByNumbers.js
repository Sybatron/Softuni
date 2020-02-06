function cook(arr) {
    let num = Number(arr.shift());

    for (let i = 0; i < arr.length; i++) {
        switch (arr[i]) {
            case 'chop':
                num/=2;
                console.log(num);
                break;
            case 'dice':
                num=Math.sqrt(num);
                console.log(num);
                break;
            case 'spice':
                num++;
                console.log(num);
                break;
            case 'bake':
                num*=3;
                console.log(num);
                break;
            case 'fillet':
                num*=0.8;
                console.log(num);
                break;
        }
    }
}