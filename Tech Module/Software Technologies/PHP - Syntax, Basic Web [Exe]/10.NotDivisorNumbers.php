<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num"/>
    <input type="submit" />
</form>

<?php
if(isset($_GET['num'])){
/*Not necessary to use intval, but recommended for Judge*/
    $n = intval($_GET['num']);

    for($index = $n; $index >= 1; $index--){
        if($n % $index != 0){
            echo $index;
            echo " ";
        }
    }
}
?>
</body>
</html>