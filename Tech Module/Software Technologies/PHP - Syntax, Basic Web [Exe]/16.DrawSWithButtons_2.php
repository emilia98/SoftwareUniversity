<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>

<?php
$matrix = [
    [1, 1, 1, 1, 1],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 0, 0, 0, 0],
    [1, 1, 1, 1, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [0, 0, 0, 0, 1],
    [1, 1, 1, 1, 1],
];

for($row = 0; $row < count($matrix); $row++){
   for($col = 0; $col < count($matrix[$row]); $col++) {
       if($matrix[$row][$col] == 1){
       ?>
             <button style="background-color: blue">1</button>
             <?php
            }
       else{?>
              <button>0</button>
              <?php
       }
   }
        ?><br/>
    <?php
}
?>
</body>
</html>