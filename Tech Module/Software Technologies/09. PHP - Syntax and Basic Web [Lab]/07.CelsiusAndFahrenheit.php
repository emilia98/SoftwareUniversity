<form>
    Celsius: <input type="text" name="cel" />
    <input type="submit" value="Convert">
    <?php if(isset($_GET['cel'])){
        $celsius = floatval($_GET['cel']);
        echo convertToFahrenheit($celsius);
    } ?>
</form>
<form>
    Fahrenheit: <input type="text" name="fah" />
    <input type="submit" value="Convert">
    <?php if(isset($_GET['fah'])){
        $fahrenheit = floatval($_GET['fah']);
        echo convertToCelsius($fahrenheit);
    } ?>
</form>

<?php
function convertToFahrenheit($celsius){
    $fahrenheit = $celsius * 1.8 + 32;
    return  "<span>{$celsius} &deg;C = {$fahrenheit} &deg;F</span>";
}

function convertToCelsius($fahrenheit){
    $celsius = ($fahrenheit - 32) / 1.8;
    return "<span>{$fahrenheit} &deg;F = {$celsius} &deg;C";
}
?>