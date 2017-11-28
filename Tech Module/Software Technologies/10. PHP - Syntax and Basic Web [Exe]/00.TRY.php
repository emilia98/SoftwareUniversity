<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php
if(isset($_GET['num'])){
    $n = intval($_GET['num']);

    for($i = $n; $i >= 2; $i--){
        if($i % 2 == 1){
            echo $i." ";
        }
    }
    echo "1";
}
?>