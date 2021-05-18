var ajaxRequest = new XMLHttpRequest();
var infoRequest = new XMLHttpRequest();

var input;

function init() {
  input = document.getElementById("search");
  input.addEventListener("keyup", sendRequest, false);
}

function sendRequest() {
  ajaxRequest.onreadystatechange = getRequest;

  ajaxRequest.open("GET", `getCountries.php?country=${input.value}`, true);
  ajaxRequest.send();
}

function getRequest() {
  if (ajaxRequest.readyState == 4 && ajaxRequest.status == 200) {
    var jsonObj = JSON.parse(ajaxRequest.responseText);
    console.log(jsonObj);

    var dataList = document.getElementById("countries");
    dataList.innerHTML = "";

    for (var i = 0; i < jsonObj.length; i++) {
      var option = document.createElement("option");
      option.value = jsonObj[i]["Name"];

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

    var table = document.getElementById("table");
    table.innerHTML = "";

    for (const [key, value] of Object.entries(country)) {
      var row = table.insertRow(0);
      var cell1 = row.insertCell(0);
      var cell2 = row.insertCell(1);
      cell1.innerHTML = key;
      cell2.innerHTML = value;
    }

    document.body.appendChild(table);
  }
}

window.addEventListener("load", init, false);
