<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $list = [];

    for($i = $n; $i >= 1; $i--){
        array_push($list, $i);
    }
    echo implode(" ", $list);
}
?>