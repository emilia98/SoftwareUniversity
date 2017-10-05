<ul>
    <?php
       for($index = 1; $index <= 20; $index++){
           $color = $index % 2 == 0 ? "green" : "blue";
    ?>
        <li><span style="color:<?= $color ?>"><?= $index ?></span></li>
    <?php
       }
    ?>
</ul>