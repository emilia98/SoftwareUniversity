<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        div{
            display: inline-block;
            width: 20px;
            height: 20px;
            margin: 5px;
        }
    </style>
</head>
<body>

<?php

for($row = 0; $row <= 4; $row++){
    $color = $row * 51;
    for($col = 0; $col <= 9; $col++){
        ?>
        <div style="background-color: rgb(<?= $color ?>,<?= $color ?>,<?= $color ?>)"></div>
        <?php
        $color += 5;
    }
    ?>
    <br/>
    <?php
}
?>

</body>
</html>