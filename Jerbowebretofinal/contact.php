<?php
$servername="localhost";
$username="root";
$password="Jerbo401*";
$dbname="Jerbo";



$Name=$_POST['Name'];
$Lastname=$_POST['Lastname'];
$Age=$_POST['Age'];
$Language=$_POST['Language'];
$Country=$_POST['Country'];
$Gender=$_POST['Gender'];
$Education=$_POST['Education'];
$MusicG=$_POST['MusicG'];
$Protection=$_POST['Protection'];
$Salud=$_POST['Salud'];


$conn=new mysqli($servername,$username,$password,$dbname);

if($conn-> connect_error){
    die ("connection failed: ". $conn->connect_error);
}



$sql = "INSERT INTO infousuarios(name, lastname, age, lnguage, country, gender, education, musicgenre, protection, Health)
 VALUES ('$Name', '$Lastname', '$Age', '$Language', '$Country', '$Gender', '$Education', '$MusicG', '$Protection', '$Salud')";

if ($conn->query($sql) === TRUE) {
	echo "New record created successfully";
  } else {
	echo "Error: " . $sql . "<br>" . $conn->error;
  }
  

?>