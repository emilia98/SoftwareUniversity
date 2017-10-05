<?php declare(strict_types=1);
if(isset($_GET['num1']) && isset($_GET['num2'])){
    $a = intval($_GET['num1']);
    $b = intval($_GET['num2']);
    $result = sum($a, $b);
    echo "$a + $b = $result";
}

function sum(int $a, int $b): int{
    return $a + $b;
}
?>

<form>
    <div>First number:</div>
    <input type="number" name="num1">
    <div>Second number:</div>
    <input type="number" name="num2">
    <div><input type="submit"/></div>
</form>

