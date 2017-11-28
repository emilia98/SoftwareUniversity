<form>
    N: <input type="text" name="num1"/>
    M: <input type="text" name="num2"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num1']) && isset($_GET['num2'])){
    $a = intval($_GET['num1']);
    $b = intval($_GET['num2']);
    echo $a * $b;
}
?>