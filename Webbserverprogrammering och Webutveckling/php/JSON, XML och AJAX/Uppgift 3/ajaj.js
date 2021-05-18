/** Deklarerar och instanserar vårt AJAX-objekt */
var ajaxRequest = new XMLHttpRequest();
var valutaRequest = new XMLHttpRequest();
var jsonObj;
function init() {
  var input = document.getElementById("calcButton");
  input.addEventListener("click", calculate, false);

  sendValutaRequest();
  sendRequest();
}

function sendValutaRequest() {
  valutaRequest.onreadystatechange = setValutaData;
  valutaRequest.open(
    "GET",
    "https://openexchangerates.org/api/currencies.json",
    true
  );
  valutaRequest.send();
}

function setValutaData() {
  if (valutaRequest.readyState == 4 && valutaRequest.status == 200) {
    jsonObj = JSON.parse(valutaRequest.responseText);

    var dataList = document.getElementById("currencyList");

    // Rensar datalistan
    dataList.innerHTML = "";

    for (const [key, value] of Object.entries(jsonObj)) {
      var option = document.createElement("option");

      // Ger ett värde till option-elementet
      option.value = key;
      option.text = value;

      // Lägger till elementet till datalistan
      dataList.appendChild(option);
    }
  }
}

/** Skickar begäran  */
function sendRequest() {
  ajaxRequest.onreadystatechange = getRequest;

  const API_KEY = "XXXXXXXXXXX";

  ajaxRequest.open(
    "GET",
    "http://openexchangerates.org/api/latest.json?app_id=" + API_KEY,
    true
  );
  ajaxRequest.send();
}

/** Tar emot begäran */
function getRequest() {
  if (ajaxRequest.readyState == 4 && ajaxRequest.status == 200) {
    jsonObj = JSON.parse(ajaxRequest.responseText);

    var dataList = document.getElementById("currencyList");

    for (var key in jsonObj.rates) {
      // Skapar ett nytt option element
      var option = document.createElement("option");

      // Ger ett värde till option-elementet
      option.value = key;

      // Lägger till elementet till datalistan
      dataList.appendChild(option);
    }
  }
}

/** Konverterar */
function calculate() {
  var key = document.getElementById("currency").value;
  var amount = document.getElementById("valueSEK").value;

  // Lite felhantering här!
  var amountInSEK = (jsonObj.rates["SEK"] / jsonObj.rates[key]) * amount;
  amountInSEK = Math.round(amountInSEK * 100) / 100;

  document.getElementById("result").innerHTML = amountInSEK + " kr";
}

window.addEventListener("load", init, false);
