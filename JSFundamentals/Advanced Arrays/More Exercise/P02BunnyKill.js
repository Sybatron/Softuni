function killBunnies(array){
    let coordinates = array
                        .pop()
                        .split(/[\s,]/)
                        .map(Number);

     array.map(element => {
       element=  element
            .split(' ')
            .map(Number);
    });


    for (let i = 0; i < array.length; i+=2) {
        let dmg = array
    }
}

killBunnies(['5 10 15 20',
'10 10 10 10',
'10 15 10 10',
'10 10 10 10',
'2,2 0,1']
);