<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>

</head>
<body>
<form>
    N: <input type="text" name="num1"/>
    M: <input type="text" name="num2"/>
    <input type="submit"/>
</form>

<ul>
    <?php
    if(isset($_GET['num1']) && isset($_GET['num2'])){
        $n = intval($_GET['num1']);
        $m = intval($_GET['num2']);

        for($list = 1; $list <= $n; $list++){?>
            <li>List <?= $list ?>
                <ul>
                    <?php
                     for($element = 1; $element <= $m; $element++){?>
                        <li>
                            Element <?= $list ?>.<?= $element ?>
                        </li>
                    <?php
                     }

                    ?>
                </ul>
            </li>
    <?php
        }
    }
?>
</ul>
</body>
</html>