<?php include 'usersession.php'?>
<?php

require_once('Classes/User.php');
include_once ('Includes/dbh.inc.php');

?>
<html>
<head>
    <title>Employee dashboard</title>
<link rel="stylesheet" type="text/css" href="Styles/Style.css">
</head>
<body>
<?php include 'navbar.html'; ?>
<?php
                $id = $_SESSION['userid'];
                $sql = "SELECT * FROM employee WHERE ID = $id;";
                //instantiate a new object of type prepared statement
                $stmt = mysqli_stmt_init($conn); //uses whichever connection variable was used to connect to the db
                //prepare the prepared statement, or rather try to parse the empty placeholder code first
                if (!mysqli_stmt_prepare($stmt, $sql)) //good practice to check for errors with placeholder before binding values to it, but we don't inject data into the SQL statement in this block
                {
                   echo "SQL statement failed.";
                }
            
                else
                    
                {
                    //try and run the parameters inside the database
                    mysqli_stmt_execute($stmt);
                    $result = mysqli_stmt_get_result($stmt);//get the result from the query
                    while($row = mysqli_fetch_assoc($result))
                    {
                        $user = new User();
						$user->set_id($row['ID']);
                        $user->set_firstname($row['FirstName']);
                        $user->set_lastname($row['LastName']);
                        $user->set_phone($row['PhoneNr']);
						$user->set_address($row['Address']);
						$user->set_email($row['Email']);
						$user->set_emergencyc($row['EmergencyC']);
						$user->set_emergencynr($row['EmergencyNr']);
						$user->set_hours($row['WorkingHours']);
						$user->set_dob($row['DOB']);
						$user->set_bsn($row['BSN']);
						$user->set_position($row['Position']);
						$user->set_certificates($row['Certifications']);
						$user->set_languages($row['Languages']);
						$user->set_ctype($row['ContractType']);
						$user->set_duration($row['ContractDuration']);
						$user->set_department($row['Department']);
						$user->set_shiftpref($row['Shiftpref']);
						
                        
						
                        }                        
                    }              
               
        ?>

<div class = "dashwrapper">
<div class="container">
            <br>
            Employee profile
            <br>
            <br>
            Name: <?php echo $user->get_firstname(); echo $user->get_lastname(); ?>
            <br>
			<br>
            Date of birth: <?php echo $user->get_dob(); ?>
            <br>
			BSN: <?php echo $user->get_bsn(); ?>
            <br>
			Languages: <?php echo $user->get_languages(); ?>
            <br>
			Certifications: <?php echo $user->get_certificates(); ?>
            <br>
			Position: <?php echo $user->get_position(); ?>
            <br>
			Department: <?php echo $user->get_department(); ?>
            <br>
			Employement: <?php echo $user->get_ctype(); ?>
            <br>
			Work hours: <?php echo $user->get_hours(); ?>
            <br>
</div>
<div class="container">
            <br>
            Contact info
            <br>

            <br>
            <label for="fname">Email:</label>
            <input type="text" id="fname" name="fname">
            <br>
			<br>
            Address: <?php echo $user->get_address(); ?>
            <br>
			<br>
            Phone: <?php echo $user->get_phone(); ?>
            <br>
			<br>
            Emergency number: <?php echo $user->get_emergencynr(); ?>
            <br>
			<br>
            Emergecy contact: <?php echo $user->get_emergencyc(); ?>
            <br>
</div>
</div>


</body>

</html>