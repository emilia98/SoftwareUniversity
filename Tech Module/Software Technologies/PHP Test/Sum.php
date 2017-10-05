<?php
function sum(int $a, int $b): int{
    return $a + $b;
}
//Correct
echo sum(6,12);
echo "<br/>";
/* Fatal error: Uncaught TypeError:
Argument 1 passed to sum() must be of the
type integer, string given*/
//echo sum("Pesho",5);

echo sum(2,"1"); //Parse-ва се второто число към int