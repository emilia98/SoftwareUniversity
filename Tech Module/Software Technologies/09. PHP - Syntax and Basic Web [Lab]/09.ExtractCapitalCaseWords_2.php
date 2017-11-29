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
    preg_match_all("/\w+/", $text, $words);

    $capitalCasedWords = [];

    foreach($words[0] as $word){
        if($word == strtoupper($word)){
            $capitalCasedWords[] = $word;
        }
    }

    $count = count($capitalCasedWords);
    $result = "";
    for($index = 0; $index < $count - 1; $index++){
        $result .= ($capitalCasedWords[$index].", ");
    }
    $result .= $capitalCasedWords[$count - 1];
    return $result;
}
?>
