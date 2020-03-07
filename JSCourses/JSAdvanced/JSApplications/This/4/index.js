function solve() {
   let contentTds = document.querySelectorAll("td");
   Array.from(contentTds).forEach(td => td.onclick = () => {
      onClick(td);
   });

   function onClick(element) {
      if (element.parentNode.getAttribute("style") === null) {
         let contentRowWithStyle = document.querySelector("tbody > tr[style]");
         if (contentRowWithStyle !== null) {
            contentRowWithStyle.removeAttribute('style');
         }
         element.parentElement.style.backgroundColor = "rgb(65, 63, 94)";
      } else {
         element.parentElement.removeAttribute('style');
      }
   }
}