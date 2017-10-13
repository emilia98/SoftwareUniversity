<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num"/>
    <input type="submit"/>
</form>

<?php
if(isset($_GET['num'])){
/*Not necessary to use intval, but recommended for Judge*/    $n = intval($_GET['num']);
    $result = 1;

    for($index = 1; $index <= $n; $index++){
        $result *= $index;
    }
    echo $result;
}
?>
</body>
</html>