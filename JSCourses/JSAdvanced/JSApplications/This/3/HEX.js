class Hex {
    constructor(value) {
        this.value = value;
    }
    valueOf() {
        return this.value;
    }
    toString() {
        return `0x${this.value.toString(16).toUpperCase()}`;
    }
    plus(number) {
        if (typeof (number) === Hex) {
            return new Hex(this.value + number.value);
        } else {
            return new Hex(this.value + number);
        }
    }
    minus(number) {
        if (typeof (number) === Hex) {
            return new Hex(this.value - number.value);
        } else {
            return new Hex(this.value - number);
        }
    }
    parse(text) {
        return text.toString(10);
    }
}

let FF = new Hex(255);
console.log(FF.toString());
console.log(FF.valueOf() + 1 == 256);
let a = new Hex(10);
let b = new Hex(5);
console.log(a.plus(b).toString());
console.log(a.plus(b).toString() === '0xF');