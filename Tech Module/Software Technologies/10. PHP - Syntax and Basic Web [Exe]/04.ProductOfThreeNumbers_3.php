<form>
    A: <input type="text" name="num1"/>
    B: <input type="text" name="num2"/>
    C: <input type="text" name="num3"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
    $nums = [ $_GET['num1'], $_GET['num2'], $_GET['num3']];

    $nums = array_map('floatval', $nums);

    $zeroes = array_filter($nums, function($num){
        return $num == 0;
    });

    $negatives = array_filter($nums, function ($num){
        return $num < 0;
    });

    $result = "";
    if(count($zeroes) > 0){
        $result = "Positive";
    }else{
        if(count($negatives) % 2 == 1){
            $result = "Negative";
        }else{
            $result = "Positive";
        }
    }

    echo $result;
}
?>