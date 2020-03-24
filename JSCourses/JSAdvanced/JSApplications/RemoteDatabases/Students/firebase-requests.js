export const apiKey = 'https://remotedatabases-8ae03.firebaseio.com/';

export const getAllStudents = () => {
	return fetch(apiKey + 'students.json').then((x) => x.json());
};

export const getStudentById = (studentId) => {
	return fetch(`${apiKey}students/${studentId}.json`).then((x) => x.json());
};

export const createNewStudent = (studentBody) => {
	return fetch(apiKey + 'students.json', {
		method : 'POST',
		body   : JSON.stringify(studentBody)
	});
};

export const updateStudent = (studentBody, studentId) => {
	return fetch(`${apiKey}students/${studentId}.json`, {
		method : 'PUT',
		body   : JSON.stringify(studentBody)
	}).then((x) => x.json());
};

export const patchStudent = (studentBody, studentId) => {
	return fetch(`${apiKey}students/${studentId}.json`, {
		method : 'PATCH',
		body   : JSON.stringify(studentBody)
	}).then((x) => x.json());
};

export const deleteStudent = (studentId) => {
	fetch(`${apiKey}students/${studentId}.json`, {
		method : 'DELETE'
	});
};
