<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>

<?php
for($row = 1; $row <= 9; $row++){
    if($row == 1 || $row == 9 || $row == 5){
        for($col = 1; $col <= 5; $col++){?>
            <button style="background-color: blue">1</button>
            <?php
        }
    }
    else if($row > 1 && $row < 5){
        for($col = 1; $col <= 5; $col++){
            if($col == 1){?>
                <button style="background-color: blue">1</button>
                <?php
            }
            else{?>
                <button>0</button>
                <?php
            }
        }
    }
    else{
        for($col = 1; $col <= 5; $col++){
            if($col == 5){?>
                <button style="background-color: blue">1</button>
                <?php
            }
            else{?>
                <button>0</button>
                <?php
            }
        }
    }
    ?>
    <br/>
    <?php
}

?>
</body>
</html>