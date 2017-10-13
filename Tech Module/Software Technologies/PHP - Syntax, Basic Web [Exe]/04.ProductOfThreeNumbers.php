<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    X: <input type="text" name="num1" />
    Y: <input type="text" name="num2" />
    Z: <input type="text" name="num3" />
    <input type="submit" />
</form>

<?php
if(isset($_GET['num1']) && isset($_GET['num2'])
   && isset($_GET['num3'])){
    $a = floatval($_GET['num1']);
    $b = floatval($_GET['num2']);
    $c = floatval($_GET['num3']);

    $negativesCount = 0;
    $hasZeros = false;
    if($a < 0){
        $negativesCount++;
    }
    else if($a == 0){
        $hasZeros = true;
    }

    if($b < 0){
        $negativesCount++;
    }
    else if($b == 0){
        $hasZeros = true;
    }

    if($c < 0){
        $negativesCount++;
    }
    else if($c == 0){
        $hasZeros = true;
    }

    if($negativesCount % 2 == 1 && $hasZeros == false){
        echo "Negative";
    }
    else{
        echo "Positive";
    }
}
?>
</body>
</html>