let myObj = {
    extend(obj) {
        for (const key in obj) {
            if (typeof (obj[key]) === 'function') {
                //TODO find a way to access __proto__ of the object
                this = obj[key];
            } else {
                this[key] = obj[key];
            }
        }
    }
};

let template = {
    extensionMethod: function () {
        return 1
    },
    extensionProperty: 'someString'
};

myObj.extend(template);
console.log(0);