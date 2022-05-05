<?php

$servername="localhost";
$username="root";
$password="Jerbo401*";
$dbname="Jerbo";

$usuario = $_POST["usuario"];
$contraseña = $_POST["contraseña"];

$conn=new mysqli($servername,$username,$password,$dbname);

if($conn-> connect_error){
    die ("connection failed: ". $conn->connect_error);
}

$sql="SELECT password from registerusers where username = '".$usuario .   "'";
$result= $conn->query($sql);

if ($result ->num_rows >0){
   while($row = $result->fetch_assoc()){
      if($row["password"]== $contraseña){
          echo "login Succes. ";
      }
      else{
          echo "Wrong Credentials. ";
      }
   }

}else{
    echo "Username does not exist";

}
$conn->close();

?>