/** Deklarerar och instanserar vårt AJAX-objekt */
var ajaxRequest = new XMLHttpRequest();
var infoRequest = new XMLHttpRequest();
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

function getInfo() {
  infoRequest.onreadystatechange = handleInfo;

  var searchTxt = "country=" + document.getElementById("search").value;

  infoRequest.open("GET", "getCountries.php?" + searchTxt, true);
  infoRequest.send(searchTxt);
}

function handleInfo() {
  if (infoRequest.readyState == 4 && infoRequest.status == 200) {
    var jsonObj = JSON.parse(infoRequest.responseText);
    let country = jsonObj[0];

    document.getElementById("countryName").innerText = country["name"];
    document.getElementById("countryCode").innerText = country["code"];
    document.getElementById("countryContinent").innerText =
      country["continent"];
    document.getElementById("countryHeadOfState").innerText =
      country["headOfState"];
    document.getElementById("countryPopulation").innerText =
      country["population"];
    document.getElementById("countryRegion").innerText = country["region"];
    document.getElementById("countrySurfaceArea").innerText =
      country["surfaceArea"];
  }
}

window.addEventListener("load", init, false);
