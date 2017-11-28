<?php
for($row = 1; $row <= 9; $row++){
    if($row == 1 || $row == 9 || $row == 5){
        for($col = 1; $col <= 5; $col++){
            echo '<button style="background-color: blue">1</button>'."\n";
        }
    }else if($row > 1 && $row < 5){
        for($col = 1; $col <= 5; $col++){
            if($col != 1){
                echo '<button>0</button>'."\n";
            }else{
                echo '<button style="background-color: blue">1</button>'."\n";
            }

        }
    }else{
        for($col = 1; $col <= 5; $col++){
            if($col != 5){
                echo '<button>0</button>'."\n";
            }else{
                echo '<button style="background-color: blue">1</button>'."\n";
            }

        }
    }
    echo "</br>";
}
?>