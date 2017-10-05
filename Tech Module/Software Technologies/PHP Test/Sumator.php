<?php declare(strict_types=1);
$sum = null;
if(isset($_GET['sum_btn'])){
    $a = intval($_GET['num_1']);
    $b = intval($_GET['num_2']);
    $sum = sum($a, $b);
}
?>

<form>
    Number 1: <input name="num_1"
                     value="<?= isset($_GET['num_1']) ?
                             $_GET['num_1'] : 0 ?>"
                     type = "number"/><br/>
    Number 2: <input name="num_2"
                     value="<?= isset($_GET['num_2']) ?
                         $_GET['num_2'] : 0 ?>"
                     type = "number"/><br/>
    <? if($sum == null): ?>
    Result: <input disabled value="<?= $sum ?>"/> <br/>
    <? endif; ?>
    <input type="submit" value="Сумирай!" name="sum_btn">
</form>

<?php
function sum(int $a, int $b): int
{
    return $a + $b;
}
?>


