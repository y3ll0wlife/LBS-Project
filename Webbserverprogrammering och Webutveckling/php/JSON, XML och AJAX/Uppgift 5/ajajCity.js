var ajaxRequestCity = new XMLHttpRequest();
var cityRequest = new XMLHttpRequest();

var cityInput;
var countryInput;

function initCity() {
  cityInput = document.getElementById("searchCity");
  cityInput.addEventListener("keyup", sendRequestCity, false);

  countryInput = document.getElementById("search");
}

function sendRequestCity() {
  ajaxRequestCity.onreadystatechange = getRequestCity;

  ajaxRequestCity.open(
    "GET",
    `getAllCity.php?country=${countryInput.value}`,
    true
  );
  ajaxRequestCity.send();
}

function getRequestCity() {
  if (ajaxRequestCity.readyState == 4 && ajaxRequestCity.status == 200) {
    var jsonObj = JSON.parse(ajaxRequestCity.responseText);
    console.log(jsonObj);
    var dataList = document.getElementById("city");
    dataList.innerHTML = "";

    for (var i = 0; i < jsonObj.length; i++) {
      var option = document.createElement("option");
      option.value = jsonObj[i]["Name"];

      dataList.appendChild(option);
    }
  }
}

function getInfoCity() {
  cityRequest.onreadystatechange = handleInfoCity;

  cityRequest.open("GET", `getCityInfo.php?city=${cityInput.value}`, true);
  cityRequest.send();
}

function handleInfoCity() {
  if (cityRequest.readyState == 4 && cityRequest.status == 200) {
    var jsonObj = JSON.parse(cityRequest.responseText);
    let city = jsonObj[0];

    var table = document.getElementById("table");
    table.innerHTML = "";

    for (const [key, value] of Object.entries(city)) {
      var row = table.insertRow(0);
      var cell1 = row.insertCell(0);
      var cell2 = row.insertCell(1);
      cell1.innerHTML = key;
      cell2.innerHTML = value;
    }

    document.body.appendChild(table);
  }
}

window.addEventListener("load", initCity, false);
