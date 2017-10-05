<ul>
    <?php
    for($index = 1; $index <= 20; $index++){
        if($index % 2 == 0){
            $color = "green";
        }else{
            $color = "blue";
        }
        echo "\t<li><span style='color:$color'>$index</span></li>\n";
    }
    ?>
</ul>