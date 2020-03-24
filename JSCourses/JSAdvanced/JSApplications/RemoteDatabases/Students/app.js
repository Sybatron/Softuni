import { extractFormData, addTableRow } from './form-helpers.js';
import { getAllStudents, updateStudent } from './firebase-requests.js';

(function solution() {
	let formRef = document.querySelector('form');
	let bodyRef = document.querySelector('tbody');

	let formConfig = [ 'firstName', 'lastName', 'facultyNumber', 'grade' ];

	getAllStudents().then((students) => {
		Object.entries(students)
			.sort((a, b) => {
				return Number(a[0]) - Number(b[0]);
			})
			.map(([ id, studentData ]) => {
				addTableRow(bodyRef, studentData, id);
			});
	});

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();

		let formResult = extractFormData(e.target, formConfig);
		if (areInputsEmpty(formResult)) {
			alert('There is blank input');
			return;
		}
		getAllStudents().then((students) => {
			let nextStudentId = !students ? 0 : Object.keys(students).length;

			updateStudent(formResult, nextStudentId)
				.then(() => getAllStudents())
				.then((students) => {
					bodyRef.innerHTML = '';
					Object.entries(students)
						.sort((a, b) => Number(a[0].id) < Number(b[0].id))
						.map(([ id, studentData ]) => {
							addTableRow(bodyRef, studentData, id);
						});
				});
		});
	});
})();
function areInputsEmpty(formResult) {
	return () => {
		Object.entries(formResult).forEach((element) => {
			if (!element[1]) {
				return false;
			}
		});
	};
}
