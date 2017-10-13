<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
    <style>
        table *{
            border: 1px solid black;
            width: 50px;
            height: 50px;
        }
    </style>
</head>
<body>
<table>
    <tr>
        <td>
            Red

        </td>
        <td>
            Green
        </td>
        <td>
            Blue
        </td>
    </tr>
<?php
for($row = 1; $row <= 5; $row++){?>
    <tr>
        <?php
        for($col = 1; $col <= 3; $col++){
            $shade = $row * 51;
            $color = "";
            if($col == 1){
                $color = "rgb(".$shade.",0".",0".")";
            }
            else if($col == 2){
            $color = "rgb("."0,".$shade.",0".")";
            }
            else{
                $color = "rgb("."0,"."0,".$shade.")";
            }
            //echo $color;
            ?>
        <td style="background-color: <?= $color ?>"> </td>
        <?php
        }
        ?>
    </tr>
    <?php
}
?>
</table>
</body>
</html>