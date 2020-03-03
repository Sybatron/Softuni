function solve() {
    let selectMenuTo = document.getElementById('selectMenuTo');
    let optionBin = document.createElement('option');
    let optionHex = document.createElement('option');

    optionBin.setAttribute('value', 'binary');
    optionBin.textContent = 'Binary';
    optionHex.setAttribute('value', 'hexadecimal');
    optionHex.textContent = 'Hexadecimal';

    selectMenuTo.appendChild(optionBin);
    selectMenuTo.appendChild(optionHex);

    document.getElementsByTagName('button')[0].addEventListener('click', convert);

    function convert() {

        let input = document.getElementById('input').value;
        let selectedValue = selectMenuTo.options[selectMenuTo.selectedIndex].value;
        let resultText = document.getElementById('result');
        resultText.value = '';

        let result = '';
        if (selectedValue === 'binary') {
            while (input !== 0) {
                result += input % 2;
                input = parseInt(input / 2);
            }
        } else if (selectedValue === 'hexadecimal') {
            while (input !== 0) {
                result += (input % 16).toString(16).toUpperCase();
                input = parseInt(input / 16);
            }
        }

        for (let i = result.length - 1; i >= 0; i--) {
            resultText.value += result[i];
        }
    }
}