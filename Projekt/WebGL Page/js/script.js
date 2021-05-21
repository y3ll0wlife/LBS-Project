/*var lightInner = document.getElementById("inLight").value;
var lightOuther = document.getElementById("outLight").value;
var rotateSpeed = parseFloat(document.getElementById("rotateSpeed").value);
*/

var lightInner = 0x00ff00;
var lightOuther = 0x8a2be2;
var rotateSpeed = 0.1;
console.log();

function getScene() {
  var scene = new THREE.Scene();
  scene.background = new THREE.Color(0xffffff);
  return scene;
}

function getCamera() {
  var aspectRatio = window.innerWidth / window.innerHeight;
  var camera = new THREE.PerspectiveCamera(75, aspectRatio, 0.1, 1000);
  camera.position.set(0, 1, -10);
  return camera;
}

function getLight(scene) {
  var light = new THREE.PointLight(lightInner, 1, 0); // Innerlight
  light.position.set(1, 1, 1);
  scene.add(light);

  var ambientLight = new THREE.AmbientLight(lightOuther); // Outer light
  scene.add(ambientLight);
  return light;
}

function getRenderer() {
  // Create the canvas with a renderer
  var renderer = new THREE.WebGLRenderer({ antialias: true });
  // Add support for retina displays
  renderer.setPixelRatio(window.devicePixelRatio);
  // Specify the size of the canvas
  renderer.setSize(window.innerWidth, window.innerHeight);
  // Add the canvas to the DOM
  document.body.appendChild(renderer.domElement);
  return renderer;
}

function getControls(camera, renderer) {
  var controls = new THREE.TrackballControls(camera, renderer.domElement);
  controls.zoomSpeed = 1;
  controls.panSpeed = 1;
  return controls;
}

var item;

function loadModel() {
  var loader = new THREE.OBJLoader();
  scene.remove(item);
  loader.load("/models/" + document.getElementById("inputGroupFile01").value.replace("C:\\fakepath", ""), function(object) {
    item = object;
    scene.add(object);
    animate();
  });
}
function animate() {
  requestAnimationFrame(animate);
  item.rotation.z += rotateSpeed;
  item.rotation.y += rotateSpeed;
  item.rotation.x += rotateSpeed;
  renderer.render(scene, camera);
}

function render() {
  requestAnimationFrame(render);
  renderer.render(scene, camera);
  controls.update();
}

var scene = getScene();
var camera = getCamera();
var light = getLight(scene);
var renderer = getRenderer();
var controls = getControls(camera, renderer);

loadModel();

render();
