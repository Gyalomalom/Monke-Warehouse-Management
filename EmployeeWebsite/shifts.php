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
						$user->set_shiftpref($row['Shiftpref']);
						$user->set_firstname($row['FirstName']);
                        
						
                        }                        
                    }              
               
        ?>

<div class = "dashwrapper">
<div class="containerdash">
            <br>
            <b>Current schedule</b>
            <br>
            <br>
            <?php
			    $id = $_SESSION['userid'];
				$query = "SELECT DateID FROM schedule WHERE EmpID = $id";
				$result = mysqli_query($conn, $query);
				if(mysqli_num_rows($result) > 0)
				{
					while($row = mysqli_fetch_array($result))
					{
						
						echo $row["DateID"]."<br />";
						
					}
			    }
			?>
			
</div>
<div class="containerdash">
            <br>
            <b>Shift preference</b>
            <br>

            <br>
            </b> <?php echo $user->get_shiftpref(); ?>
            <br>
			<br>
            <br>
			<label for="shift">Preferred shift:</label>
            <form action="Handlers/updateshift.php" method="post" enctype="multipart/form-data">
            <select name="shift">
            <option value="Morning">Morning</option>
            <option value="Day">Day</option>
            <option value="Evening">Evening</option>
            </select>
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			
			
			    <div class="updatebutton">
        		<button type = "submit" name = "submit" id = "btnupdate">Change preferred shift</button>
				</div>
            </form>
</div>

<div class="containerdash">
            <br>
            <b>Call in sick</b>
            <br>
            <br>
            <form action="Handlers/sickleave.php" method="post" enctype="multipart/form-data">
			<br>
            <br>
			<label for="choose">Choose days:</label>
			<br>
			<br>
            <br>
            <label for="start">Start:</label>
            <input type="date" name="start">
			<br>
			<br>
			<label for="end">End:</label>
            <input type="date" name="end">
			<br>
			<br>
			<br>
			<br>
			<br>
			<br>
			<div class="updatebutton">
            <button type = "submit" name = "submit" id = "btnupdate">Call in sick</button>
		    </div>
            </form>
</div>
</div>


</body>
<footer><?php include 'footer.php'; ?></footer>
</html>