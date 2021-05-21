var scene = new THREE.Scene(); // Vi skapar en scen varible
var camera = new THREE.PerspectiveCamera(1000, window.innerWidth / window.innerHeight, 0.1, 1000); // Vi skapar en camera variable

var renderer = new THREE.WebGLRenderer(); // Samt en renderar varible
renderer.setSize(1200, 500); // Vi sätter storleken på render variable
renderer.setClearColor(0xf1f8ff, 1);
document.getElementById("stupid3dmodels").appendChild(renderer.domElement); // Sedan lägger vi till render elementet till html bodyn

var geometry = new THREE.BoxGeometry(2, 2, 2); // Vi skapar en gemoetry varible

for (var i = 0; i < geometry.faces.length; i++) {
  // En for loop för att loopa igenom alla delar av kuben
  var face = geometry.faces[i]; // Vi skapar en varible face och sätter den till en av de 12 faces av gemotry varible
  face.color.setHex(0x00ff00); // Vi sätter face till en hex färg
}

var material = new THREE.MeshBasicMaterial({ vertexColors: THREE.FaceColors }); // Vi skapar en material variable
var cube = new THREE.Mesh(geometry, material); // Vi skapar en cube varible och ger den gemotry och matriel
cube.position.x = -2; // Vi sätter den på -2 x vilket sätter den på vänster sida av skärmen
scene.add(cube); // Vi lägger till den i scenen

for (var i = 0; i < geometry.faces.length; i++) {
  // Sedan loopar vi igenom faces igen
  var face = geometry.faces[i]; // Sätter face till en av de 12 gemotry face
  face.color.setHex(0xffffff * Math.random()); // Och ger den en slumpad hex färg
}

var material = new THREE.MeshBasicMaterial({ vertexColors: THREE.FaceColors }); // Se tidigare
var cube2 = new THREE.Mesh(geometry, material); // Se tidigare
cube2.position.x = 2; // Sätter cube2's x postion till 2 vilket är höger sida
scene.add(cube2); // Lägger till i scenne

camera.position.z = 5; // Vi sätter camera postionen på en z axel av 5 för att se båda kuberna

var animate = function() {
  // Vi skapar en function för att animera kuberna
  requestAnimationFrame(animate); // Vi kallar på functionen requestAnimationFrame med animate function för att three js ska göra sin magi

  cube.rotation.x -= 0.01 / Math.sin(200); // Vi sätter rotationen på x till -0.01 / Sinus(3)
  cube.rotation.y -= 0.01 / Math.sin(200); // Vi sätter rotationen på y till 0.01 / Sinus(6)
  // Detta gör så att den spinnar runt av sig själv vilket gör att man ser att dem är 3d

  cube2.rotation.x += 0.01 / Math.sin(200); // Här snurarr vi bara den 0.01 hela tiden
  cube2.rotation.y += 0.01 / Math.sin(200); // På både x och y

  renderer.render(scene, camera); // Sedan renderar vi senene
};

animate(); // Vi kallar på animate funktionen
