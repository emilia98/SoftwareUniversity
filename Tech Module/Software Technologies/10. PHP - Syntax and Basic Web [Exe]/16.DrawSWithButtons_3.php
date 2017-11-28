<?php
$matrix = [
    [1, 1, 1, 1, 1],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 1, 1, 1, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [1, 1, 1, 1, 1],
];

for($row = 0; $row < count($matrix); $row++){
    for($col = 0; $col < count($matrix[$row]); $col++){
        $num = $matrix[$row][$col];

        if($num == 1){
            ?>
            <button style="background-color: blue">1</button>
            <?php
        }else{
            ?>
            <button>0</button>
            <?php
        }
    }
    echo "</br>";
}
?>