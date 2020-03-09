function solution() {
	let myObj = {
		extend: function(template) {
			Object.keys(template).forEach((key) => {
				if (typeof template[key] === 'function') {
					Object.getPrototypeOf(this)[key] = template[key];
				} else {
					this[key] = template[key];
				}
			});
		}
	};
	return myObj;
	// let template = {
	// 	extensionMethod: function() {
	// 		return 1;
	// 	},
	// 	extensionProperty: 'someString'
	// };

	// myObj.extend(template);
	// console.log(0);
	// console.log(myObj);
}
