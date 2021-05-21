<?php

namespace MyApp;

use Ratchet\MessageComponentInterface;
use Ratchet\ConnectionInterface;




class Chat implements MessageComponentInterface
{
    protected $clients;

    public function __construct()
    {
        $this->clients = new \SplObjectStorage;
        echo "Server started....\n";
    }

    public function onOpen(ConnectionInterface $conn)
    {
        $client = new \stdClass();
        $client->conn = $conn;
        $client->username = substr($conn->httpRequest->getUri()->getQuery("username"), 9);

        $client->connectionData = array(
            "user-agent" => $conn->httpRequest->getHeaders()["User-Agent"][0],
            "language" => $conn->httpRequest->getHeaders()["Accept-Language"][0],
            "resourceId" => $conn->resourceId

        );
        $this->clients->attach($client);

        echo "New connection! ({$conn->resourceId})\n";

        $data = array("type" => "USER_JOINED", "username" => $client->username, "message" => null, "time" => date("H:i"));

        foreach ($this->clients as $client) {
            $client->conn->send(json_encode($data));
        }

        WriteToLog($data);
    }


    public function onMessage(ConnectionInterface $from, $msg)
    {
        $numRecv = count($this->clients) - 1;
        $username = "";

        foreach ($this->clients as $client) {
            if ($from === $client->conn) {
                $username = $client->username;
            }
        }

        echo sprintf(
            'Connection %d sending message "%s" to %d other connection%s' . "\n",
            $from->resourceId,
            $msg,
            $numRecv,
            $numRecv == 1 ? '' : 's'
        );
        date_default_timezone_set("Europe/Stockholm");



        $data = array("type" => "MESSAGE", "username" => $username, "message" => CleanContent($msg), "time" => date("H:i"));

        foreach ($this->clients as $client) {
            $client->conn->send(json_encode($data));
        }

        WriteToLog($data);
    }

    public function onClose(ConnectionInterface $conn)
    {
        $this->clients->detach($conn);
        echo "Connection {$conn->resourceId} has disconnected\n";

        $data = array("type" => "USER_LEAVE", "username" => substr($conn->httpRequest->getUri()->getQuery("username"), 9), "message" => null, "time" => date("H:i"));


        WriteToLog($data);
    }

    public function onError(ConnectionInterface $conn, \Exception $e)
    {
        echo "An error has occurred: {$e->getMessage()}\n";
        $conn->close();
    }
}

function CleanContent($string)
{
    return str_replace("\\", "", htmlspecialchars($string));
}

function WriteToLog($data)
{
    $chatLog = fopen("./src/chat.log", "a") or die("Unable to open file!");
    fwrite($chatLog, $data["type"] . ":" . $data["time"] . ":" . $data["username"] . ":" . $data["message"] . "\n");
    fclose($chatLog);
}
