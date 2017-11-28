<style>
    div{
        display: inline-block;
        width: 30px;
        height: 30px;
        margin: 5px;
    }
</style>

<?php
for($row = 0; $row < 5; $row++){
    $color = $row * 51;
    for($col = 0; $col < 10; $col++){
        $textColor = "$color, $color, $color";
        ?>

        <div style="background-color: rgb(<?= $textColor ?>)"></div>
        <?php
        $color += 5;
    }
    echo "</br>"."\n";
}
?>
