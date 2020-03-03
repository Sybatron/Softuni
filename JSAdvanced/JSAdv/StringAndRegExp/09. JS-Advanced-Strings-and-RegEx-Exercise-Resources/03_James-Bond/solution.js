function solve() {
    let input = document.getElementById('array').value;
    let array=JSON.parse(input);
    let specialKey=array[0];

    let regex = new RegExp(specialKey+' {1,}(?<message>[!%$#A-Z]{8,})([ ,]|$)','gi');

    let matches= array[1].match(regex);
    for (const match of matches) {
        
    }
}
