function getArticleGenerator(articles) {
    let index = 0;
    return function getNextArticle() {
        if (index < articles.length) {
            let article = document.createElement('article');
            article.innerText = articles[index];
            index++;
            document.getElementsByTagName('div')[0].appendChild(article);
        }
    }
}