<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num"/>
    <input type="submit"/>
</form>

<?php
if(isset($_GET['num'])){
    $number = intval($_GET['num']);

    for($index = $number; $index > 1; $index--){
        $isPrime = checkIfPrime($index);

        if(!$isPrime){
            echo $index, " ";
        }
    }
}

function checkIfPrime(int $num): bool {
    for($divider = 2; $divider <= sqrt($num); $divider++){
        if($num % $divider == 0){
            return true;
        }
    }
    return false;
}
?>
</body>
</html>