var conn = new WebSocket(
	`ws://localhost:8080?username=${new URLSearchParams(
		window.location.search
	).get("username")}`
);

conn.onopen = function (e) {
	document.body.addEventListener("keypress", function (e){
		if (e.key === 'Enter') {
			transmitMessage();
		}
	})

	console.log("Connection established!");

};

conn.onmessage = function (msg) {
	const data = JSON.parse(msg.data);
	//console.log(data);

	const chatContainer = document.getElementById("chat-container");
	const chat = document.createElement("div");

	if(data.type === "MESSAGE") {
		chat.innerHTML = `<code> [${data.time}] </code><strong>${data.username}</strong>: ${data.message}`;
	}
	else if(data.type === "USER_JOINED") {
		chat.innerHTML = `<code> [${data.time}] </code><strong>${data.username}</strong> joined the chat`;
		chat.style.backgroundColor = "#4CAF50";
		chat.style.padding = "5px";
	}
	else if (data.type === "USER_LEAVE"){
		chat.innerHTML = `<code> [${data.time}] </code><strong>${data.username}</strong> left the chat`;
		chat.style.backgroundColor = "#af504c";
		chat.style.padding = "5px";
	}
	
	chatContainer.appendChild(chat);
	jumpToBot()
};


function transmitMessage() {
	const chatBox = document.getElementById("chatText");
	if (chatBox.value === "") return;

	conn.send(chatBox.value);

	chatBox.value = "";
	chatBox.focus();
	jumpToBot()
}

function jumpToBot() {
	window.scrollTo(0,document.body.scrollHeight);
}