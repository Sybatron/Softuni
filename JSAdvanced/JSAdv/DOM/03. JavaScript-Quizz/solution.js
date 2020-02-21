function solve() {
  let trueAnswers = 0;
  let answers = 0;
  let leftAnswers = document.getElementsByClassName('quiz-answer low-value');
  let rightAnswers = document.getElementsByClassName('quiz-answer hight-value');

  Array.from(leftAnswers).forEach(element => {
    element.addEventListener('click', onAnswerClicked(element.getElementsByClassName('answer-text')));
  });
  Array.from(rightAnswers).forEach(element => {
    element.addEventListener('click', onAnswerClicked(element.getElementsByClassName('answer-text')));
  });

  function onAnswerClicked(element) {
    let elText = element.value;
    switch (elText) {
      case 'onclick':
      case 'JSON.stringify()':
      case 'A programming API for HTML and XML documents':
        trueAnswers++;
        break;
    }

    let curentSection = document.getElementsByTagName('section')[answers];
    curentSection.setAttribute('class', 'hidden');
    answers++;
    if (answers != 3) {
      let nextSection = document.getElementsByTagName('section')[answers];
      nextSection.setAttribute('class', '');
    }

    if (answers === 3) {
      let resultDiv = document.getElementById('results')
      let resultText = resultDiv.getElementsByTagName('h1')[0];

      if (trueAnswers >= 0) {
        resultText.value = 'You are recognized as top JavaScript fan!';
      } else {
        resultText.value= `You have ${trueAnswers} right answers`;
      }
    }
  }
}