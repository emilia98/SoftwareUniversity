<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $primes = [];

    for($i = $n; $i > 1; $i--){
        if(isPrime($i)){
            array_push($primes, $i);
        }
    }

    echo implode(" ", $primes);
}

function isPrime($num){
    for($cnt = 2; $cnt <= sqrt($num); $cnt++){
        if($num % $cnt == 0){
            return false;
        }
    }
    return true;
}
?>