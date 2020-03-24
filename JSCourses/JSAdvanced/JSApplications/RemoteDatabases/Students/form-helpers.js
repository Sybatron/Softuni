export function extractFormData(formRef, formConfig) {
	return formConfig.reduce((acc, inputName) => {
		acc[inputName] = formRef.elements[inputName].value;
		return acc;
	}, {});
}

export function fillFormWithData(formRef, formValue) {
	Object.entries(formValue).map(([ inputName, value ]) => {
		if (formRef.elements[inputName]) {
			formRef.elements[inputName].value = value;
		}
	});
}

export function clearFormData(formRef) {
	let tempInputs = formRef.querySelectorAll('input');
	tempInputs.forEach((element) => {
		element.value = '';
	});
}

export function addTableRow(tbody, studentValue, studentId) {
	let tempRow = document.createElement('tr');
	tempRow.setAttribute('data-student-id', studentId);
	if (!studentValue.tags) {
		studentValue.tags = 'No tags';
	}
	tempRow.innerHTML = `
    <td>${studentId}</td>
    <td>${studentValue.firstName}</td>
	<td>${studentValue.lastName}</td>
    <td>${studentValue.facultyNumber}</td>
    <td>${studentValue.grade}</td>`;

	tbody.appendChild(tempRow);
}
