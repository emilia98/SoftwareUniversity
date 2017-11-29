<form>
    <textarea rows="10" name="text"><?php
        if(isset($_GET['text'])){
            $text = $_GET['text'];
            echo extractCapitalCaseWords($text);
        };
        ?></textarea> <br>
    <input type="submit" value="Extract">

</form>

<?php
function extractCapitalCaseWords($text){
    preg_match_all("/\b[A-Z]+\b/", $text, $words);
    return implode($words[0], ", ");
}
?>
