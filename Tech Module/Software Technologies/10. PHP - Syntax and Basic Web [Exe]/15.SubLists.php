<form>
    N: <input type="text" name="num1"/>
    M: <input type="text" name="num2"/>
    <input type="submit" value="Изпрати!" />
</form>

<?php
if(isset($_GET['num1']) && isset($_GET['num2'])){
    $listCount = intval($_GET['num1']);
    $elementsCount = intval($_GET['num2']);

    ?>
<ul>
<?php
for($listIndex = 1; $listIndex <= $listCount; $listIndex++){
    echo "\t<li>List $listIndex"."\n";
    echo "\t\t<ul>"."\n";
    for($elementIndex = 1; $elementIndex <= $elementsCount; $elementIndex++){
        echo "\t\t\t<li>Element $listIndex.$elementIndex</li>"."\n";
    }
    echo "\t\t</ul>"."\n";
    echo "\t</li>"."\n";
}
?>
</ul>
<?php
}
?>