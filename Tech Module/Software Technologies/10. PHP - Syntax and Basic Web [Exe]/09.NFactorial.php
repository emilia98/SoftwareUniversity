<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $result = 1;

    for($i = 2; $i <= $n; $i++){
        $result *= $i;
    }
    echo $result;
}
?>