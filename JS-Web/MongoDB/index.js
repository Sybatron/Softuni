const { ObjectID } = require('mongodb');
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

const userPostSchema = mongoose.Schema({
	title: String,
	body: String,
	userId: { type: mongoose.Schema.Types.ObjectId, ref: 'user' },
});

userSchema.methods.printAllData = function () {
	console.log(this.name, this.age, this.email);
};

userSchema.virtual('allNames').get(function () {
	return this.name.split(' ');
});

mongoose.connect('mongodb://127.0.0.1:27017/softuni-test').then(() => {
	console.log('Connected to database');

	//* Hooks
	userSchema.pre('save', () => {
		console.log('Pre save');
	});

	const User = mongoose.model('user', userSchema);
	const UserPosts = mongoose.model('userPost', userPostSchema);

	//* populate
	// UserPosts.findById('5f9deed864cfbe24b4e91110')
	// 	.populate('userId')
	// 	.then((post) => {
	// 		console.log(JSON.stringify(post, null, 2));
	// 	});

	//* Creating
	// UserPosts.create({
	// 	title: 'Post 1',
	// 	body: 'Hello world!',
	// 	userId: '5f9db0a0b0e8fb69c0163220',
	// }).then(() => console.log('Post added'));

	// User.create({ name: 'Test 1', age: 50, email: 'email' })
	// 	.then(() => {})
	// 	.catch((err) => console.error(err));

	//#region Find
	// User.find({ age: { $gt: 10, $lt: 50 } }).then((data) => {
	// 	data.forEach((user) => user.printAllData());
	// });

	// User.find({ age: { $gt: 10, $lt: 50 } }).then((data) => {
	// 	data.forEach((user) => console.log(user.allNames));
	// });

	// User.find({ age: { $gt: 9 } }).then((data) => {
	// 	console.log(data);
	// });
	//#endregion

	//* Different way to insert
	// const newUser = new User({ name: 'Test', age: 10, email: 'test@abv.bg' });
	// newUser.save().then(() => {
	// 	console.log('User was added to db');
	// });

	//* Insert many data objs
	// User.insertMany([{ name: 'Test', age: 40, email: 'example@abv.bg' }]);

	//* Update data
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
