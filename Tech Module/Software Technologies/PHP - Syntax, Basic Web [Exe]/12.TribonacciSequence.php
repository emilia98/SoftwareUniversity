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
    $beforePrevious = 1;
    $previous = 1;
    $afterPrevious = 2;
    $result = 1;

    for($index = 1; $index <= $n; $index++){
        if($index == 1 || $index == 2){
            echo 1, " ";
        }
        else if($index == 3){
            echo 2, " ";
        }
        else{
            $result = $beforePrevious + $previous + $afterPrevious;
            $beforePrevious = $previous;
            $previous = $afterPrevious;
            $afterPrevious = $result;

            echo $result;

            if($index < $n){
                echo " ";
            }
        }
    }
}
?>
</body>
</html>