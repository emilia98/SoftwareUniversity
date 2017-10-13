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
for($row = 0; $row < 255; $row += 51){
    for($col = $row; $col < ($row + 50); $col += 5){
        $color = "rgb($col, $col, $col)";
        ?>
        <div style="background-color: <?= $color ?>"></div>
     <?php
    }
    ?>
    <br/>
<?php
}
?>
</body>
</html>