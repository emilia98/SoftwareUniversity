<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="number" name="num" />
    <input type="submit"/>
</form>

<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $beforePrevious = 1;
    $previous = 1;
    $result = 1;

    for($index = 1; $index <= $n; $index++){
        if($index == 1 || $index == 2){
            echo $result, " ";
        }
        else{
            $result = $previous + $beforePrevious;
            $beforePrevious = $previous;
            $previous = $result;

            if($index == $n){
                echo $result;
            }
            else{
                echo $result, " ";
            }
        }
    }
}
?>
</body>
</html>