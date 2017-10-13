<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit"/>
</form>
<?php
if(isset($_GET['num'])){
    $count = intval($_GET['num']);

    for($index = 1; $index <= $count; $index++){?>
        <button><?= $index?></button>
<?php
    }
}
?>
</body>
</html>