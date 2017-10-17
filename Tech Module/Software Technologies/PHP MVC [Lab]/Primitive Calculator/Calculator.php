<?php
include 'Controllers/CalculatorService.php';
include 'Models/MathOperation.php';
include 'Models/MathRepository.php';
include 'Controllers/CalculatorController.php';


$calculatorController = new CalculatorController();
if(isset($_GET['sum_btn'])){
    $calculatorController->calculate();
}
else{
    $calculatorController->index();
}
?>
