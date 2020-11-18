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
                        $user->set_email($row['Email']);
                        $user->set_pass($row['Password']);
						
                        }                        
                    }              
               
        ?>

<div class = "dashwrapper">
<div class="container">
            <br>
            User profile
            <br>
            <br>
            Name: <?php echo $user->get_firstname(); echo $user->get_lastname(); ?>
            <br>
			<br>
            Email: <?php echo $user->get_email(); ?>
            <br>
</div>
<div class="container">
<br>
            Phone: +4206969
            <br>
</div>
</div>

</body>

<footer><?php include 'footer.php'; ?></footer>
</html>