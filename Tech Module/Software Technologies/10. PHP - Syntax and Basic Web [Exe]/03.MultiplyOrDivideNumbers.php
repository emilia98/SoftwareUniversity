<form>
    A: <input type="text" name="num1"/>
    B: <input type="text" name="num2"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num1']) && isset($_GET['num2'])){
    $a = floatval($_GET['num1']);
    $b = floatval($_GET['num2']);

    if($a <= $b){
        echo $a * $b;
    }else{
        echo $a / $b;
    }
}
?>