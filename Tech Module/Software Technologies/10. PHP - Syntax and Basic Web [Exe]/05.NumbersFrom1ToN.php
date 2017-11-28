<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);

    for($i = 1; $i < $n; $i++){
        echo $i." ";
    }
    echo $i;
}
?>