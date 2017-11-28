<form>
    N: <input type="text" name="num"/>
    <input type="submit" value="Изпращане"/>
</form>
<?php

if(isset($_GET['num'])){
    $count = intval($_GET['num']);

    for($i = 1; $i <= $count; $i++){
        echo "<button>$i</button>";
    }
}
?>