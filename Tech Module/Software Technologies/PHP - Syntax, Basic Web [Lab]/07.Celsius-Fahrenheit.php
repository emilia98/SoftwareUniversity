<?php declare(strict_types=1);
$riseFor1Celsius = 33.8 - 32;
?>
    <form>
        Celsius: <input type="text" name="cel"/>
        <input type="submit" value="Convert">
        <?php if(isset($_GET['cel'])){
            $celsius = floatval($_GET['cel']);
            echo convertFromCelToFah($celsius, $riseFor1Celsius);
        } ?>
    </form>

    <form>
        Fahrenheit: <input type="text" name="fah"/>
        <input type="submit" value="Convert">
        <?php if(isset($_GET['fah'])){
            $fahrenheit = floatVal($_GET['fah']);
            echo convertFromFahToCel($fahrenheit, $riseFor1Celsius);
        }?>
    </form>

<?php

function convertFromCelToFah(float $celsius,
                             float $riseFor1Celsius): string{
    $fahrenheit = $riseFor1Celsius*$celsius + 32;
    $msgAfterCel = "$celsius &deg C = $fahrenheit &deg F";
    return $msgAfterCel;
}

function convertFromFahToCel(float $fahrenheit,
                             float $riseFor1Celsius): string{
    $celsius = ($fahrenheit - 32) / $riseFor1Celsius;
    $msgAfterFah = "$fahrenheit &deg F = $celsius &deg C";
    return $msgAfterFah;
}
?>