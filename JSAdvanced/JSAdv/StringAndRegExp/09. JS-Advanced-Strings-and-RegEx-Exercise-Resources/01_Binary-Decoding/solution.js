function solve() {
	let binaryText = document.getElementById('input').value;
	let weightValue = binaryText
		.split('')
		.reduce((accumulator, currentValue) => {
			return Number(currentValue) + accumulator;
		}, 0);

	if (weightValue >= 10) {
		function getSum(numSum) {
			if (numSum <= 9) {
				return numSum;
			}

			numSum = numSum
				.toString()
				.split('')
				.reduce((accumulator, currentValue) => {
					return Number(currentValue) + accumulator;
				}, 0);
			return getSum(numSum);
		}

		weightValue = getSum(weightValue);
	}

	binaryText = binaryText.slice(weightValue, binaryText.length - weightValue);
	let binaryArray = binaryText.match(/[01]{8}/g);
	let result = '';
	for (const binText of binaryArray) {
		result += String.fromCharCode(parseInt(binText, 2));
	}

	let resultText = document.getElementById('resultOutput');
	result = result.replace(/[^A-Za-z\s]/, '');
	resultText.innerHTML = result.toString();
}