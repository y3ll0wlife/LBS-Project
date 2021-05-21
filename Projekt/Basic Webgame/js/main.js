var myGamePiece;
var myObstacles = [];
var myScore;

function startGame() {
  document.getElementById("restart").style.display = "none";
  document.getElementById("score").style.display = "none";

  if (document.getElementById("slimJim").checked == true) myGamePiece = new component(15, 7, "img/bird.png", 50, 120, "image");
  else myGamePiece = new component(40, 30, "img/bird.png", 20, 120, "image");
  myBackground = new component(800, 500, "img/bg.png", 0, 0, "image");
  myScore = new component("70%", "Consolas", "white", 380, 30, "text"); // Score variable

  myGameArea.start();
}

var myGameArea = {
  canvas: document.createElement("canvas"),
  start: function() {
    this.canvas.width = 800;
    this.canvas.height = 500;
    this.context = this.canvas.getContext("2d");
    document.body.insertBefore(this.canvas, document.body.childNodes[0]);
    this.frameNo = 0;
    this.interval = setInterval(updateGameArea, 20);
  },
  clear: function() {
    this.context.clearRect(0, 0, this.canvas.width, this.canvas.height);
  },
  stop: function() {
    clearInterval(this.interval);
  }
};

function component(width, height, color, x, y, type) {
  if (type == "image") {
    this.image = new Image();
    this.image.src = color;
  }
  this.type = type;
  this.width = width;
  this.height = height;
  this.speedX = 0;
  this.speedY = 0;
  this.x = x;
  this.y = y;
  this.update = function() {
    ctx = myGameArea.context;
    if (this.type == "text") {
      ctx.font = this.width + " " + this.height;
      ctx.fillStyle = color;
      ctx.fillText(this.text, this.x, this.y);
    }
    if (type == "image") {
      ctx.drawImage(this.image, this.x, this.y, this.width, this.height);
    } else {
      ctx.fillStyle = color;
      ctx.fillRect(this.x, this.y, this.width, this.height);
    }
  };
  this.newPos = function() {
    this.x += this.speedX;
    this.y += this.speedY;
  };
  this.crashWith = function(otherobj) {
    var myleft = this.x;
    var myright = this.x + this.width;
    var mytop = this.y;
    var mybottom = this.y + this.height;
    var otherleft = otherobj.x;
    var otherright = otherobj.x + otherobj.width;
    var othertop = otherobj.y;
    var otherbottom = otherobj.y + otherobj.height;
    var crash = true;

    if (mybottom < othertop || mytop > otherbottom || myright < otherleft || myleft > otherright) crash = false;
    if (this.y <= 0 || this.y >= 470 || this.x + this.width <= 34 || this.x >= 770) crash = true; // Border crash
    if (crash == false) document.getElementById("restart").hidden = true;
    if (crash == true) {
      document.getElementById("restart").style.display = "block";
      document.getElementById("score").style.display = "block";
      document.getElementById("score").innerHTML = myScore.text;
    }

    return crash;
  };
}

function updateGameArea() {
  var x, height, gap, minHeight, maxHeight, minGap, maxGap;
  for (i = 0; i < myObstacles.length; i += 1) {
    if (myGamePiece.crashWith(myObstacles[i])) {
      myGameArea.stop();
      return;
    }
  }
  myGameArea.clear();
  myBackground.newPos();
  myBackground.update();
  myGameArea.frameNo += 1;
  if (myGameArea.frameNo == 1 || everyinterval(255)) {
    x = myGameArea.canvas.width;
    minHeight = 20;
    maxHeight = 200;
    height = Math.floor(Math.random() * (maxHeight - minHeight + 1) + minHeight);
    minGap = document.getElementById("rangeMin").value;
    maxGap = document.getElementById("rangeMax").value;
    gap = Math.floor(Math.random() * (maxGap - minGap + 1)) + 82; // Calc gap

    if (document.getElementById("invisPipes").checked == true) {
      color = "#81B5BA";
      lineColor = "#81B5BA";
    } else {
      color = "green"; // Makes pipes green
      lineColor = "limegreen";
    }

    myObstacles.push(new component(40, height, lineColor, x, 10)); // Top Pipe line
    myObstacles.push(new component(40, x - height - gap, lineColor, x, height + gap - 10)); // Bot Pipe line
    myObstacles.push(new component(40, height, color, x, 0)); // Top Pipe
    myObstacles.push(new component(40, x - height - gap, color, x, height + gap)); // Bot pipe
  }
  for (i = 0; i < myObstacles.length; i += 1) {
    myObstacles[i].speedX = -1;
    myObstacles[i].newPos();
    myObstacles[i].update();
  }
  myScore.text = "SCORE: " + myGameArea.frameNo;
  myScore.update();
  myGamePiece.newPos();
  myGamePiece.update();
}

function everyinterval(n) {
  if ((myGameArea.frameNo / n) % 1 == 0) {
    return true;
  }
  return false;
}

function moveup() {
  myGamePiece.speedY = -document.getElementById("rangeUp").value / 10;
}

function movedown() {
  myGamePiece.speedY = document.getElementById("rangeDown").value / 10;
}

function moveleft() {
  myGamePiece.speedX = -document.getElementById("rangeLeft").value / 10;
}

function moveright() {
  myGamePiece.speedX = document.getElementById("rangeRight").value / 10;
}

function clearmove() {
  myGamePiece.speedX = 0;
  myGamePiece.speedY = 0;
}

const log = document.getElementById("canvas");
document.addEventListener("keypress", logKey);

function logKey(e) {
  if (document.getElementById("inverted").checked == true) {
    if (e.code == "KeyS") moveup();
    if (e.code == "KeyW") movedown();
    if (e.code == "KeyD") moveleft();
    if (e.code == "KeyA") moveright();
    if (e.code == "Space" && document.getElementById("restart").style.display == "block") restartGame();
  } else if (document.getElementById("randomize").checked == true) {
    var randomKey = Math.floor(Math.random() * 5);
    if (randomKey == 1) moveup();
    if (randomKey == 2) movedown();
    if (randomKey == 3) moveleft();
    if (randomKey == 4) moveright();
    if (e.code == "Space" && document.getElementById("restart").style.display == "block") restartGame();
  } else {
    if (e.code == "KeyW") moveup();
    if (e.code == "KeyS") movedown();
    if (e.code == "KeyA") moveleft();
    if (e.code == "KeyD") moveright();
    if (e.code == "Space" && document.getElementById("restart").style.display == "block") restartGame();
  }
}

function restartGame() {
  location.reload();
  //window.location.replace("https://www.youtube.com/channel/UCowAMrdDQ8IMogZ_JnH-DYw");
}
