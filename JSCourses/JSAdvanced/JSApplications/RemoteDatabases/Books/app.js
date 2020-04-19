import {
	createNewBook,
	getAllBooks,
	getBookById,
	deleteBook,
	updateBook,
	patchBook
} from './firebase-requests.js';

(function solution() {
	let formInputs = [ 'title', 'author', 'isbn' ];
	let tagInputs = [ 'tags' ];

	let formRef = document.querySelector('form');
	let tBodyRef = document.querySelector('tbody');
	let loadBooksButtonRef = document.querySelector('#loadBooks');

	let tagFormRef = document.querySelector('#tagForm');

	formRef.addEventListener('submit', (e) => {
		e.preventDefault();

		let parsedForm = extractFormData(formRef, formInputs);

		//* My alternative solution
		// let bookId = formRef.dataset.bookId;

		// if (bookId) {
		// 	updateBook(parsedForm, bookId);
		// 	formRef.dataset.bookId = '';
		// } else {
		// 	createNewBook(parsedForm);
		// }

		createNewBook(parsedForm);
		clearFormData(formRef);
		setTimeout(() => {
			loadAllBooks(tBodyRef);
		}, 250);
	});

	loadBooksButtonRef.addEventListener('click', () => {
		loadAllBooks(tBodyRef);
	});

	tBodyRef.addEventListener('click', (e) => {
		let targetBookId = e.target.closest('tr').dataset.bookId;

		if (e.target instanceof HTMLButtonElement) {
			const { method } = e.target.dataset;
			if (method === 'edit') {
				updateBook(extractFormData(formRef, formInputs), targetBookId);
			}
			if (method === 'delete') {
				deleteBook(targetBookId);
			}

			setTimeout(() => {
				loadAllBooks(tBodyRef);
			}, 250);
			return;
		}

		getBookById(targetBookId).then((x) => {
			fillFormWithData(formRef, x);
			fillFormWithData(tagFormRef, x);
			tagFormRef.setAttribute('data-book-id', targetBookId);
		});
	});

	tagFormRef.addEventListener('submit', (e) => {
		e.preventDefault();

		let parsedForm = extractFormData(tagFormRef, tagInputs);
		console.log(parsedForm);
		parsedForm.tags = parsedForm.tags.split(', ').filter(Boolean);
		console.log(parsedForm);
		patchBook(parsedForm, tagFormRef.dataset.bookId);

		setTimeout(() => {
			loadAllBooks(tBodyRef);
		}, 250);
	});
})();

function loadAllBooks(tBodyRef) {
	getAllBooks().then((resp) => {
		tBodyRef.innerHTML = '';
		Object.entries(resp).map(([ id, bookValue ]) => {
			addTableRow(tBodyRef, bookValue, id);
		});
	});
}

function addTableRow(tbody, bookValue, bookId) {
	let tempRow = document.createElement('tr');
	tempRow.setAttribute('data-book-id', bookId);
	if (!bookValue.tags) {
		bookValue.tags = 'No tags';
	}
	tempRow.innerHTML =
		`
    <td>${bookValue.title}</td>
    <td>${bookValue.author}</td>
	<td>${bookValue.isbn}</td>
	<td>${bookValue.tags}</td>` +
		//* Lecture solution
		`<td>
		<button data-method="edit">Edit</button>
		<button data-method="delete">Delete</button>
	</td>`;

	//* My alternative solution
	// let tempCell = document.createElement('td');
	// let deleteBtn = document.createElement('button');
	// deleteBtn.textContent = 'Delete';
	// deleteBtn.addEventListener('click', () => {
	// 	deleteBook(bookId);
	// 	setTimeout(() => {
	// 		loadAllBooks(tbody);
	// 	}, 250);
	// });

	// tempCell.appendChild(deleteBtn);
	// tempRow.appendChild(tempCell);

	tbody.appendChild(tempRow);
}

function extractFormData(formRef, formConfig) {
	return formConfig.reduce((acc, inputName) => {
		acc[inputName] = formRef.elements[inputName].value;
		return acc;
	}, {});
}

function fillFormWithData(formRef, formValue) {
	Object.entries(formValue).map(([ inputName, value ]) => {
		if (formRef.elements[inputName]) {
			formRef.elements[inputName].value = value;
		}
	});

	//* This was for my alternative solution
	// formRef.setAttribute('data-book-id', bookId);
}

function clearFormData(formRef) {
	let tempInputs = formRef.querySelectorAll('input'); 
	tempInputs.forEach((element) => {
		element.value = '';
	});
}
