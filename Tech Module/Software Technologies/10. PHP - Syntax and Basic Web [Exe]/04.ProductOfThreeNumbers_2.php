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

    $product = $a * $b * $c;

    if($product < 0){
        echo "Negative";
    }else{
        echo "Positive";
    }
}
?>