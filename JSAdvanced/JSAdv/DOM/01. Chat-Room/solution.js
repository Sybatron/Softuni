function solve() {
   document.getElementById("send").addEventListener("click", sendMessage);

   function sendMessage() {
      let newMessage = document.createElement('div');
      let messageText = document.getElementById('chat_input');
      newMessage.setAttribute('class', 'message my-message');

      newMessage.textContent = messageText.value;
      document.getElementById('chat_messages').appendChild(newMessage);

      messageText.value = '';
   }
}