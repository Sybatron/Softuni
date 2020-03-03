function AddRemove(commands) {
    let result = 0;
    let newArr = [];

    for (let i = 0; i < commands.length; i++) {
        result++;
        switch (commands[i]) {
            case 'add':
                newArr.push(result);
                break;
            case 'remove':
                newArr.pop(result);
                break;
        }
    }

    if(newArr.length>0){
        console.log(newArr.join('\n'));
    } else{
        console.log('Empty');
    }
}