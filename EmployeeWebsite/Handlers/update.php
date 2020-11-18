<?php
include_once ('../Includes/dbh.inc.php');
?>
<!DOCTYPE html>


<?php
if (isset($_POST['submit'])){

$id = $_POST['id'];
$email = $_POST['email'];
$address = $_POST['address'];    
$phone = $_POST['phone'];	
$emergencynr = $_POST['emergencynr'];
$emergencyc = $_POST['emergencyc'];

// Check connection
if ($conn->connect_error) {
  die("Connection failed: " . $conn->connect_error);
}else{

// sql to update a record
$sql = "UPDATE `employee` SET `Email` = '$email', `Address` = '$address', `Phone` = '$phone', `EmergencyC` = '$emergencyc', `EmergencyNr` = '$emergencynr' WHERE `items`.`ID` = $id;";

if ($conn->query($sql) === TRUE) {
  header("Location: ../index.php");
} else {
  echo "Error";
}
}
}else{
    echo "Error";
}

?>
            