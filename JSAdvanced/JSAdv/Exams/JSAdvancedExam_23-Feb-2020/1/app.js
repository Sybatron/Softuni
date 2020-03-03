function solve() {
   let author = document.getElementById('creator');
   let title = document.getElementById('title');
   let category = document.getElementById('category');
   let content = document.getElementById('content');

   let archiveList = document.querySelector('.archive-section ul');
   let articleSection = document.querySelector('main > section')

   let createBtn = document.getElementsByClassName('btn')[0];

   createBtn.addEventListener('click', createArticle);

   function createArticle(el) {
      el.preventDefault();
      let article = document.createElement('article');

      let titleArticle = document.createElement('h1');
      titleArticle.innerText = title.value;

      let categoryArticle = document.createElement('p');
      categoryArticle.innerText = 'Category:';
      let categoryNameArticle = document.createElement('strong');
      categoryNameArticle.innerText = category.value;;
      categoryArticle.appendChild(categoryNameArticle);

      let creatorArticle = document.createElement('p');
      creatorArticle.innerText = 'Creator:';
      let creatorNameArticle = document.createElement('strong');
      creatorNameArticle.innerText = author.value;;
      creatorArticle.appendChild(creatorNameArticle);

      let contentArticle = document.createElement('p');
      contentArticle.innerText = content.value;;

      article.appendChild(titleArticle);
      article.appendChild(categoryArticle);
      article.appendChild(creatorArticle);
      article.appendChild(contentArticle);

      let buttonsDiv = document.createElement('div');
      buttonsDiv.setAttribute('class', 'buttons');

      let deleteBtn = document.createElement('button');
      deleteBtn.setAttribute('class', 'btn delete');
      deleteBtn.innerText = 'Delete';
      deleteBtn.addEventListener('click', () => {
         article.remove();
      });

      let archiveBtn = document.createElement('button');
      archiveBtn.setAttribute('class', 'btn archive');
      archiveBtn.innerText = 'Archive';
      archiveBtn.addEventListener('click', () => {
         moveArticleToArchive(titleArticle.innerText,archiveList);
         article.remove();
      });

      buttonsDiv.appendChild(deleteBtn);
      buttonsDiv.appendChild(archiveBtn);

      article.appendChild(buttonsDiv);
      articleSection.appendChild(article);
   }

   function moveArticleToArchive(articleTitle,archiveList) {
      let archiveItem = document.createElement('li');
      archiveItem.innerText = articleTitle;
      archiveList.appendChild(archiveItem);

      function sortByName(a, b) {
         return a.innerHTML.toLowerCase().localeCompare(b.innerHTML.toLowerCase());
     }
     
        let list = Array.from(archiveList.getElementsByTagName('li'));
        list.sort(sortByName);
        for (var i = 0; i < list.length; i++) {
            list[i].parentNode.appendChild(list[i]);
        }
   }
}

