
<?php

$servername="localhost";
$username="root";
$password="Jerbo401*";
$dbname="Jerbo";

$usuario = $_POST["usuario"];
$contraseña = $_POST["contraseña"];
$FechaInicio= date("Y-m-d H:i:s");

$conn= new mysqli($servername,$username,$password,$dbname);

if($conn-> connect_error){
    die ("connection failed: ". $conn->connect_error);
}

$sql="SELECT username from registerusers where username = '".$usuario .   "'";
$result= $conn->query($sql);



if ($result ->num_rows >0){
    echo "Username Taken";

}else{
    echo "Creating User....";
   
    $sql2="INSERT INTO registerusers(username, password ,fecha ) VALUES ('".$usuario."', '".$contraseña."', '".$FechaInicio."')";
    
    
    if ($conn->query($sql2) === TRUE) {
        echo "New record created successfully";
      } else {
        echo "Error: " . $sql2 . "<br>" . $conn->error;
      }
      
     

}

$conn->close();

?>