<style>
    td,th{
        width: 50px;
        height: 50px;
        border: 1px solid black;
    }
</style>
<table>
    <tr>
        <td>Red</td>
        <td>Green</td>
        <td>Blue</td>
    </tr>
    <?php
    for($row = 51; $row <= 255; $row += 51){
        echo "<tr>";
        for($col = 1; $col <= 3; $col++){
            $color = "";
            if($col == 1){
                $color = "rgb($row, 0, 0)";
            }
            else if($col == 2){
                $color = "rgb(0, $row, 0)";
            }else{
                $color = "rgb(0, 0, $row)";
            }
            echo "<td style='background-color:$color'></td>";
        }
        echo "</tr>"."\n";
    }
    ?>
</table>
