// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Clear the content of the message box 
function clearMessageBox() {
    document.getElementById("messageInput").value = "";
}

// Get the input field
var input = document.getElementById("messageInput");

// Execute a function when the user releases a key on the keyboard
input.addEventListener("keyup", function(event) {
  // Number 13 is the "Enter" key on the keyboard
  if (event.keyCode === 13) {
    // Trigger the button element with a click
    document.getElementById("sendButton").click();
  }
});