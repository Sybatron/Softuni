function solution() {
    let addGiftButton = document.getElementsByTagName('button')[0];
    addGiftButton.addEventListener('click', addGift);
    let gifts = [];

    function addGift() {
        let input = document.getElementsByTagName('input')[0];

        let listOfGifts = document.getElementsByTagName('ul')[0];

        let gift = document.createElement('li');
        gift.setAttribute('class', 'gift');
        gift.innerHTML = input.value;
        gift.value = input.value;

        let sendButton = document.createElement('button');
        sendButton.setAttribute('id', 'sendButton');
        sendButton.innerText = 'Send';
        sendButton.addEventListener('click', function () {
            addToSentGifts(gift.value);
            listOfGifts.removeChild(gift);
        });

        let discardButton = document.createElement('button');
        discardButton.setAttribute('id', 'discardButton');
        discardButton.innerText = 'Discard';
        discardButton.addEventListener('click', function () {
            addToDiscardedGifts(gift.value);
            listOfGifts.removeChild(gift);
        });

        gift.appendChild(sendButton);
        gift.appendChild(discardButton);

        listOfGifts.appendChild(gift);

        input.value = '';

        function sortByName(a, b) {
            return a.innerHTML.toLowerCase().localeCompare(b.innerHTML.toLowerCase());
        }
        
        //* How to sort list items
        let list = Array.from(listOfGifts.getElementsByTagName('li'));
        list.sort(sortByName);
        for (var i = 0; i < list.length; i++) {
            list[i].parentNode.appendChild(list[i]);
        }
    }


    function addToSentGifts(value) {
        addToList(1, value);
    }

    function addToDiscardedGifts(value) {
        addToList(2, value);
    }

    function addToList(index, value) {
        let listOfGifts = document.getElementsByTagName('ul')[index];

        let gift = document.createElement('li');
        gift.setAttribute('class', 'gift');
        gift.innerText = value;

        listOfGifts.appendChild(gift);
    }
}