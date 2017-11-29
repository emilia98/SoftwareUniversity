<form>
  <textarea rows="10" name="lines"><?php if(isset($_GET['lines'])){
          $str = $_GET['lines'];
          echo sortLines($str);} ?>
  </textarea> <br>
    <input type="submit" value="Sort">
</form>

<?php
function sortLines($str){
    $array = explode("\n", $str);
    sort($array);
    return implode("\n", $array);
}
?>