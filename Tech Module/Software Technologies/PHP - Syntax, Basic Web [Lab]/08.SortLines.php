<form>
    <textarea rows="10" name="lines"><?php
        if(isset($_GET['lines'])){
            $strings = $_GET['lines'];
            echo sortTextArea($strings);
        } ?></textarea>
    <br/>
    <input type="submit" value="Sort" />
</form>

<?php
function sortTextArea(string $strings): string{
    $arrayOfStrings = explode("\n", $strings);
    sort($arrayOfStrings);
    $count = count($arrayOfStrings);
    $strings = "";
    for($index = 0; $index < $count - 1; $index++){
        $strings .= $arrayOfStrings[$index];
        $strings .= "\n";
    }
    $strings .= $arrayOfStrings[$count - 1];
    return $strings;
}
?>

