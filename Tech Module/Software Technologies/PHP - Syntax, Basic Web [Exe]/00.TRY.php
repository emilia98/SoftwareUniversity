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
                <button style="background-color: #FFFFFF">0</button>
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
                <button style="background-color: #FFFFFF">0</button>
                <?php
            }
        }
    }
    ?>
    <br/>
    <?php
}
?>