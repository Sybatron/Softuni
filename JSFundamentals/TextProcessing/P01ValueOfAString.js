function valueOfString(input) {
    let data = input.split(/\s/);
    let text =data[0];
    let letterCase = data[1];
    function lowerCaseSum(str) {
        let sum = 0;

        for (let i = 0; i < str.length; i++) {
            if (str[i].toLowerCase() === str[i]) {
                let el = str.charCodeAt(i);
                sum += parseInt(el);
            }
        }

        return sum;
    }

    function upperCaseSum(str) {
        let sum = 0;

        for (let i = 0; i < str.length; i++) {
            if (str[i].toUpperCase() === str[i]) {
                let el = str.charCodeAt(i);
                sum += parseInt(el);
            }
        }

        return sum;
    }

    let sum = 0;
    letterCase === 'LOWERCASE' ?
        sum = lowerCaseSum(text) :
        sum = upperCaseSum(text);

    console.log(`The total sum is: ${sum}`);
}

valueOfString(`HelloFromMyAwesomePROGRAM
LOWERCASE
`);