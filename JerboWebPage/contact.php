<?php
$servername="10.124.0.2";
$username="root";
$password="Jerbo401*";
$dbname="Jerbo";

$conn=new mysqli($servername,$username,$password,$dbname);

$Name=$_POST['Name']
$Lastname=$_POST['Lastname']
$Age=$_POST['Age']
$Language=$_POST['Language']
$Country=$_POST['Country']
$Gender=$_POST['Gender']
$Education=$_POST['Education']
$MusicG=$_POST['MusicG']
$Protection=$_POST['Protection']
$Salud=$_POST['Salud']


$sql = "INSERT INTO `[** PONER NOMBRE TABLA **]` VALUES ('$Name', '$Lastname', '$Age', '$Language', '$Country', '$Gender', '$Education', '$MusicG', '$Protection', '$Salud')";

$rs = mysqli_query($con, $sql);

if($rs)
{
	echo "Contact Records Inserted";
}

?>