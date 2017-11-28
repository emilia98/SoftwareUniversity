<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $list = [];

    for($i = 1; $i <= $n; $i++){
        $list[] = $i;
    }
    echo implode(" ", $list);
}
?>