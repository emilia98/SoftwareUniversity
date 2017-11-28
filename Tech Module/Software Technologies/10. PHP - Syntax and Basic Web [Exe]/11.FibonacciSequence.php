<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);

    $seq = [1, 1];
    if($n == 1){
        echo 1;
    } else{
        $a1 = 1;
        $a2 = 1;

        for($i = 3; $i <= $n; $i++){
            $sum = $a1 + $a2;
            $seq[] = $sum;
            $a1 = $a2;
            $a2 = $sum;
        }
        echo implode(" ", $seq);
    }
}
?>