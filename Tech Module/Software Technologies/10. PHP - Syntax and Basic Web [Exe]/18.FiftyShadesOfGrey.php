<style>
    div{
        display: inline-block;
        width: 30px;
        height: 30px;
        margin: 5px;
    }
</style>

<?php
for($row = 0; $row <= 204; $row += 51){
    for($col = $row; $col <= $row + 45; $col += 5){
        $color = "rgb($col, $col, $col)";
        echo "<div style='background-color: $color'></div>"."\n";
    }
    echo "</br>"."\n";
}
?>
