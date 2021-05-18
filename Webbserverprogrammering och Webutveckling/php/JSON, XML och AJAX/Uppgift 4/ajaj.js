var username = document.getElementById("username");
var password = document.getElementById("password");
var message = document.getElementById("message");
var dataElem = document.getElementById("data");

var ajaxRequest = new XMLHttpRequest();
var ajaxLogoutRequest = new XMLHttpRequest();

function signIn() {
  sendRequest();
}

function sendRequest() {
  ajaxRequest.onreadystatechange = getRequest;

  ajaxRequest.open(
    "GET",
    `login.php?username=${username.value}&password=${password.value}`,
    true
  );
  ajaxRequest.send();
}

function getRequest() {
  if (ajaxRequest.readyState == 4 && ajaxRequest.status == 200) {
    var data = JSON.parse(ajaxRequest.responseText);
    if (!data.status) return (message.innerText = "Fel lösenord");

    message.innerText = `Välkommen ${data.username}`;
    dataElem.innerText = `Din favorite färg är ${data.color}`;
  }
}

function logout() {
  sendRequestLogout();
}

function sendRequestLogout() {
  ajaxLogoutRequest.onreadystatechange = getRequestLogout;

  ajaxLogoutRequest.open("GET", `logout.php`, true);
  ajaxLogoutRequest.send();
}

function getRequestLogout() {
  if (ajaxLogoutRequest.readyState == 4 && ajaxLogoutRequest.status == 200) {
    message.innerText = ``;
    dataElem.innerText = ``;
  }
}

window.addEventListener("load", signIn, false);
