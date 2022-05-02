<?php
$servername="10.124.0.2";
$username="root";
$password="Jerbo401*";
$dbname="Jerbo";


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




$conn=new mysqli($servername,$username,$password,$dbname);
if($conn-> connect_error){
    die ("connection failed: ". $conn->connect_error);
}else{
    echo "Registering Answers";
    $stmt= $conn->prepare("insert into infousuarios(name,lastname,age,language,country,gender,education,musicgenre,protection,health) values(?,?,?,?,?,?,?,?,?,?,?)")
    $stmt->bind_param("ssisssssss",$Name,$Lastname,$Age,$Language,$Country,$Gender,$Education,$MusicG,$Protection,$Salud );
    stmt->execute();
    echo "the answers have been registered"
    $stmt->close();
    $conn->close();
    
      

}






?>