<style>
    div{
        display: inline-block;
        width: 150px;
        margin: 5px;
        padding: 2px;
    }
</style>

<?php
  for($i1 = 0; $i1 <= 255; $i1 += 51){
    for($i2 = 0; $i2 <= 255; $i2 += 51){
        for($i3 = 0; $i3 <= 255; $i3 += 51){
            $result = "rgb($i1, $i2, $i3)";?>
            <div style= "background:<?= $result ?>"><?= $result ?></div>
        <?php
        }
    }
  }
?>
