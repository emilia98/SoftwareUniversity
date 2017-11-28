<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $seq = [1, 1, 2];

    if($n == 1){
        echo $seq[0];
    }else if($n == 2){
        echo $seq[0]." ".$seq[1];
    }else{
        $a1 = 1;
        $a2 = 1;
        $a3 = 2;

        for($i = 4; $i <= $n; $i++){
            $sum = $a1 + $a2 + $a3;
            $seq[] = $sum;
            $a1 = $a2;
            $a2 = $a3;
            $a3 = $sum;
        }
        echo implode(" ", $seq);
    }
}
?>