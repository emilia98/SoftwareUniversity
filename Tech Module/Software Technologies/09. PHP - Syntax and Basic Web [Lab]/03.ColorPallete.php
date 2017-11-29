<style>
    div{
        display: inline-block;
        width: 150px;
        padding: 2px;
        margin: 5px;
    }
</style>
<?php
for($col1 = 0; $col1 <= 255; $col1 += 51){
    for($col2 = 0; $col2 <= 255; $col2 += 51){
        for($col3 = 0;  $col3 <= 255; $col3 += 51){
            $color = "rgb($col1, $col2, $col3)";
            echo "<div style='background: $color'>$color</div>";
        }
    }
}
?>