<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num" />
    <input type="submit" />
</form>

<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);

    for($index = $n; $index >= 1; $index--){
        echo $index;
        if($index > 1){
            echo " ";
        }
    }
}
?>
</body>
</html>