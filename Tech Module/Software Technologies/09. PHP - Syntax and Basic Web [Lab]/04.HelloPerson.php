<form>
    <input type="text" name="person"/>
    <input type="submit" value="Submit"/>
</form>
<?php
if(isset($_GET['person'])){
    $name = htmlspecialchars($_GET['person']);
    echo "Hello, $name!";
}
?>