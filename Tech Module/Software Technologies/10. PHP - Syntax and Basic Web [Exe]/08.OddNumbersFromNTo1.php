<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $oddNums = [];

    for($i = $n; $i >= 1; $i--){
        if($i % 2 == 1){
            array_push($oddNums, $i);
        }
    }

    echo implode(' ', $oddNums);
}
?>