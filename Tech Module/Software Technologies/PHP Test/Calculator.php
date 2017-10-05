<?php declare(strict_types=1);
$result = null;
$commands=['sum','substract','multiply','divide'];
if(isset($_GET['sum_btn'])){
    $a = intval($_GET['num_1']);
    $b = intval($_GET['num_2']);
    $operation=$_GET['operation'];

    if(!in_array($operation, $commands)){
        throw new Exception("Wrong Command");
    }
    $result = $operation($a, $b);

    /* With $commands, we ensure ourselves for hack attacks
       and we don't need all these conditionals
    if($operation == "sum"){
        $result = sum($a,$b);
    }else if($operation == "substract"){
        $result = substract($a,$b);
    }else if($operation == "multiply"){
        $result = multiply($a,$b);
    }else if($operation == "divide"){
        $result = divide($a,$b);
    }
    */
}
?>

<form>
    Number 1: <input name="num_1"
                     value="<?= isset($_GET['num_1']) ?
                               $_GET['num_1'] : 0 ?>"
                     type="number"/> <br/>
    Number 2: <input name="num_2"
                     value="<?= isset($_GET['num_2']) ?
                         $_GET['num_2'] : 0 ?>"
                     type="number"/> <br/>
    <select name="operation">
        <option value="sum">Sum</option>
        <option value="substract">Substract</option>
        <option value="multiply">Multiply</option>
        <option value="divide">Divide</option>
    </select>
    <? if($sum != null): ?>
    Result: <input disabled value="<?= $result ?>" /><br/>
    <? endif; ?>
    <input type="submit" value="Изчисли!" name="sum_btn"/>
</form>

<?php
function sum(int $a, int $b): int
{
    return $a + $b;
}

function substract(int $a, int $b): int
{
    return $a - $b;
}

function multiply(int $a, int $b): int
{
    return $a * $b;
}
function divide(int $a, int $b): float
{
    return $a / $b;
}

?>