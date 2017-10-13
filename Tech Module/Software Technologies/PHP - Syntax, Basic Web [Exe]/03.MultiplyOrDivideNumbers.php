<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1"/>
    M: <input type="text" name="num2"/>
    <input type="submit"/>
</form>

<?php
if(isset($_GET['num1']) && isset($_GET['num2'])){
    $a = floatval($_GET['num1']);
    $b = floatval($_GET['num2']);
    $result = 0;

    if($a <= $b){
        $result = $a * $b;
    }
    else{
        $result = $a / $b;
    }
    echo $result;
}
?>
</body>
</html>