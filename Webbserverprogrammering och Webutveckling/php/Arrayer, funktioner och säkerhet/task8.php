<!-- 
Gör om samma sida, men skapa en klass User som används till att lagra användardata.
-->
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Task 8</title>
</head>
<body>
<form method="GET">
        First name: <input type="text" name="firstName"> <br/>
        Last name: <input type="text" name="lastName"><br/>
        Username: <input type="text" name="username"><br/>
        Password: <input type="password" name="password"><br/>
      
        <input type="submit" value="Sign up">
    </form>

    <?php 
        mb_internal_encoding("UTF-8");

        class User{
            public $firstName;
            public $lastName;
            public $username;
            public $password;

            function setUser($fN, $lN, $uN, $psw){
                $this->firstName = $fN;
                $this->lastName = $lN;
                $this->username = $uN;
                $this->password = $psw;
            }

        }
        
        if(isset($_GET["password"])){
            function cleanData($s){
                return str_replace(" ", "", str_replace("\\", "", strip_tags($s)));
            }

        
            $firstName = cleanData($_GET["firstName"]);
            $lastName = cleanData($_GET["lastName"]);
            $username = cleanData($_GET["username"]);
            $password = cleanData($_GET["password"]);

            $user = new User();
            $user->setUser($firstName, $lastName, $username, $password);

          
            echo " <br/> Data from form: <br/>";
            echo $user->firstName . " " . $user->lastName . "<br/>"; 
            echo $user->username . " " . $user->password . "<br/>";
        }
       
    ?>
</body>
</html>