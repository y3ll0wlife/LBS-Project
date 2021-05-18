/** Deklarerar och instanserar vårt AJAX-objekt */
var ajaxRequest = new XMLHttpRequest();
var input;
function init() {
  input = document.getElementById("search");
  input.addEventListener("keyup", sendRequest, false);
}

/** Skickar begäran  */
function sendRequest() {
  ajaxRequest.onreadystatechange = getRequest;

  var searchTxt = "country=" + input.value;

  ajaxRequest.open("GET", "getCountries.php?" + searchTxt, true);
  ajaxRequest.send(searchTxt);
}

/** Tar emot begäran */
function getRequest() {
  if (ajaxRequest.readyState == 4 && ajaxRequest.status == 200) {
    var jsonObj = JSON.parse(ajaxRequest.responseText);
    console.log(jsonObj);

    var dataList = document.getElementById("countries");

    // Rensar datalistan
    dataList.innerHTML = "";

    for (var i = 0; i < jsonObj.length; i++) {
      // Skapar ett nytt option element
      var option = document.createElement("option");

      // Ger ett värde till option-elementet
      option.value = jsonObj[i]["name"];

      // Lägger till elementet till datalistan
      dataList.appendChild(option);
    }
  }
}

window.addEventListener("load", init, false);
