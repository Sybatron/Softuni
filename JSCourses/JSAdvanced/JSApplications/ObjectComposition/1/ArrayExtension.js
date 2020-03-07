(function solve() {
    Array.prototype.last = () => {
        return this[this.length - 1];
    };

    Array.prototype.skip = n => {
        return this.slice(n - 1, this.length);
    };

    Array.prototype.take = n => {
        return this.slice(0, n - 1);
    };

    Array.prototype.sum = () => {
        return this.reduce((a, b) => a + b, 0);
    };

    Array.prototype.avarage = () => {
        return this.sum() / this.length;
    };
}());

let arr = [1, 2, 3];
console.log(arr.last());