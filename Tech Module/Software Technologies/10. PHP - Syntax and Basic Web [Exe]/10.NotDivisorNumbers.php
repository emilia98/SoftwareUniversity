<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $notDivisorNumbers = [];

    for($cnt = $n; $cnt >= 2; $cnt--){
        if($n % $cnt != 0){
            $notDivisorNumbers[] = $cnt;
        }
    }
    echo implode(" ", $notDivisorNumbers);
}
?>