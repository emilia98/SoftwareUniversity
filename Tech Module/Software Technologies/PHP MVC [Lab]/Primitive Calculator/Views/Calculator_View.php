<?php /** @var $result float */
/** @var $operations MathOperation[] */
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
        <?php
        foreach($operations as $operation):

            ?>

            <option value="<?= $operation->getFunctionName();?>">
                <?= $operation->getDisplayName(); ?>
            </option>
        <?php endforeach; ?>
    </select>
    <? if($result != null): ?>
        Резултат: <input disabled value="<?= $result ?>" /><br/>
    <? endif; ?>
    <input type="submit" value="Изчисли!" name="sum_btn"/>

</form>