function emailValidator(input) {
    function makeUpper(str) {
        str = str.toUpperCase();
        console.log(str);
        return str;
    }

    function makeLower(str) {
        str = str.toLowerCase();
        console.log(str);
        return str;
    }

    function getDomain(str, count) {
        let index = str.length - count;
        let result = str.substring(index);
        console.log(result);
    }

    function getUsername(str) {
        let aIndex = str.indexOf('@');

        if (aIndex != -1) {
            let result = str.substring(0, aIndex);
            console.log(result);
        } else {
            console.log(`The email ${str} doesn't contain the @ symbol.`);
        }
    }

    function replace(str, char) {
        str = str.replace(new RegExp(char, 'g'), '-');
        console.log(str);
        return str;
    }

    function encrypt(str) {
        let result = [];
        for (let i = 0; i < str.length; i++) {
            result.push(str.charCodeAt(i));
        }

        console.log(result.join(' '));
    }

    let email = input.shift();

    for (let i = 0; i < input.length; i++) {
        const element = input[i];

        if (element === 'Make Upper') {
            email = makeUpper(email);
        } else if (element === 'Make Lower') {
            email = makeLower(email);
        } else if (/GetDomain \d{1,}/.test(element)) {
            let arr = element.split(' ');
            let count = parseInt(arr[1]);
            getDomain(email, count);
        } else if (element === 'GetUsername') {
            getUsername(email);
        } else if (/Replace ./.test(element)) {
            let arr = element.split(' ');
            let letter = arr[1];
            replace(email, letter);
        } else if (element === 'Encrypt') {
            encrypt(email);
        } else {
            break;
        }
    }
}

emailValidator([
    'Mike123@somemail.com',
    'Make Upper',
    'GetDomain 3',
    'GetUsername',
    'Encrypt',
    'Complete'
]);