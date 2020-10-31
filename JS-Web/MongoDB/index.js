const mongoose = require('mongoose');

const userSchema = mongoose.Schema({
	name: {
		type: String,
		required: [true, 'Name required'],
	},
	age: {
		type: Number,
		min: [10, 'Age must be at least 10'],
		required: [true, 'Age required'],
	},
	email: String,
});
userSchema.methods.printAllData = function () {
	console.log(this.name, this.age, this.email);
};

userSchema.virtual('allNames').get(function () {
	return this.name.split(' ');
});

mongoose.connect('mongodb://127.0.0.1:27017/softuni-test').then(() => {
	console.log('Connected to database');

	const User = mongoose.model('user', userSchema);

	// User.create({ name: 'Test', age: 100, email: 'email' })
	// 	.then(() => {})
	// 	.catch((err) => console.error(err));

	// User.find({ age: { $gt: 10, $lt: 50 } }).then((data) => {
	// 	data.forEach((user) => user.printAllData());
	// });

	// User.find({ age: { $gt: 10, $lt: 50 } }).then((data) => {
	// 	data.forEach((user) => console.log(user.allNames));
	// });

	// User.find({ age: { $gt: 9 } }).then((data) => {
	// 	console.log(data);
	// });

	// const newUser = new User({ name: 'Test', age: 10, email: 'test@abv.bg' });
	// newUser.save().then(() => {
	// 	console.log('User was added to db');
	// });

	// User.insertMany([{ name: 'Test', age: 40, email: 'example@abv.bg' }]);

	// User.find({ name: /a/ })
	// 	.then((users) => {
	// 		const updates = users.map((user) => {
	// 			user.name = 'Ivan';
	// 			return user.save();
	// 		});

	// 		console.log(users);
	// 		return Promise.all(updates);
	// 	})
	// 	.then(() => {
	// 		console.log('All entries have been updated!');
	// 	});
});
