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
    for($row = 51; $row <= 255; $row += 51){ ?>
        <tr>
            <td style='background-color: rgb(<?= $row ?>, 0, 0)'></td>
            <td style='background-color: rgb(0,<?= $row ?>, 0)'></td>
            <td style='background-color: rgb(0, 0, <?= $row ?>)'></td>
        </tr>
        <?php
    }
    ?>
</table>
