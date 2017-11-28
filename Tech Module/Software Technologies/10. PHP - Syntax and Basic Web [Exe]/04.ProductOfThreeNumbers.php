<form>
    A: <input type="text" name="num1"/>
    B: <input type="text" name="num2"/>
    C: <input type="text" name="num3"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
    $a = floatval($_GET['num1']);
    $b = floatval($_GET['num2']);
    $c = floatval($_GET['num3']);

    $hasZeroes = false;
    $negativeNumbers = 0;

    if($a == 0 || $b == 0 || $c == 0){
        $hasZeroes = true;
    }else{
        if($a < 0){
            $negativeNumbers++;
        }

        if($b < 0){
            $negativeNumbers++;
        }

        if($c < 0){
            $negativeNumbers++;
        }
    }

    if($negativeNumbers % 2 == 1 && !$hasZeroes){
        echo "Negative";
    }else{
        echo "Positive";
    }
}
?>