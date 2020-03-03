function solve() {
   let itemInputs = document.querySelectorAll('#add-new input');
   let addButton = document.querySelector('#add-new button');
   let avaibleProductList = document.querySelector('ul');
   let myProductList = document.querySelector('#myProducts ul');

   let filterInput = document.querySelector('#filter');
   let filterTrigger = document.querySelector('.filter button');

   let totalPriceRef = document.querySelectorAll('h1');
   let priceSoFar = 0.00;

   let buyButton = document.querySelector('#myProducts button');

   buyButton.addEventListener('click', buyHandler);
   avaibleProductList.addEventListener('click', addProductToBasketHandler);
   addButton.addEventListener('click', addItemHandler);
   filterTrigger.addEventListener('click', filterItems);

   function buyHandler() {
      myProductList.innerText = '';
      totalPriceRef[1].innerHTML = 'Total Price: 0.00';
      priceSoFar = 0;

   }

   function addProductToBasketHandler(e) {
      if (e.target.tagName === 'BUTTON') {
         let productPrice = e.target.parentNode.parentNode.querySelector('div > strong').textContent;
         let productName = e.target.parentNode.parentNode.querySelector('span').textContent;
         let basketElement = document.createElement('li');
         basketElement.innerText = productName;

         let productQuantityCountRef = e.target.parentNode.parentNode.querySelector('strong');
         let parsedQuantity = Number(productQuantityCountRef.innerHTML.split(':')[1].trim());

         if (parsedQuantity - 1 === 0) {
            e.target.parentNode.parentNode.remove();
         }

         productQuantityCountRef.innerHTML = `Available: ${--parsedQuantity}`;

         let basketElementProductPrice = document.createElement('strong');
         basketElementProductPrice.innerText = productPrice;

         basketElement.appendChild(basketElementProductPrice);
         myProductList.appendChild(basketElement);
         priceSoFar += Number(productPrice)
         totalPriceRef[1].innerHTML = `Total Price: ${priceSoFar.toFixed(2)}`;


      }
   }

   function filterItems() {
      let filterValue = filterInput.value;
      Array.from(avaibleProductList.children).forEach(el => {
         let productName = el.querySelector('span');
         if (productName.innerText.toLocaleLowerCase().includes(filterValue)) {
            el.style.display = 'block';
         } else {
            el.style.display = 'none';
         }
      });
   }

   function addItemHandler(el) {
      el.preventDefault();

      let newItemLine = document.createElement('li');

      let itemName = document.createElement('span');
      itemName.innerText = itemInputs[0].value;

      let itemQuantity = document.createElement('strong');
      itemQuantity.innerText = `Available: ${itemInputs[1].value}`;

      newItemLine.appendChild(itemName);
      newItemLine.appendChild(itemQuantity);

      let priceContainer = document.createElement('div');
      let priceElement = document.createElement('strong');
      priceElement.innerText = Number(itemInputs[2].value).toFixed(2);

      let addButton = document.createElement('button');
      addButton.innerText = `Add to Client's List`;

      priceContainer.appendChild(priceElement);
      priceContainer.appendChild(addButton);
      newItemLine.appendChild(priceContainer);

      avaibleProductList.appendChild(newItemLine);
      itemInputs[0].value = '';
      itemInputs[1].value = '';
      itemInputs[2].value = '';
   }
}