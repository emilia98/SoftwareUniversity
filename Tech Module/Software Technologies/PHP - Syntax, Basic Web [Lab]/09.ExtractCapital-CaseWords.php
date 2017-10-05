<?php declare(strict_types=1);?>
<form>
    <textarea rows="10" name="text"><?php
            if(isset($_GET['text'])){
                $text = $_GET['text'];
                echo extractWords($text);
            }
        ?></textarea> <br/>
    <input type="submit" name="btn-submit" value="Extract">
</form>

<?php
function extractWords(string $text): string{
    preg_match_all('/\w+/', $text, $words);

    foreach($words[0] as $word){
        if(strtoupper($word) == $word){
            $uppercased[] = $word;
        }
    }
    $result = implode(", ", $uppercased);
    return $result;
}
?>