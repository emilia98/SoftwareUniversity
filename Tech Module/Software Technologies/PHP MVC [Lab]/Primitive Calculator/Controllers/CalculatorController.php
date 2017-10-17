<?php

class CalculatorController
{
    public function index()
    {
        //show the calculator with data
        $mathRepo = new MathRepository();
        $operations = $mathRepo->findAll();
        $result = null;
        include 'Views/Calculator_View.php';
    }

    public function calculate(){
        $calculatorService = new CalculatorService();
        $result = null;

        $a = intval($_GET['num_1']);
        $b = intval($_GET['num_2']);
        $operation=$_GET['operation'];

        if($operation == 'sum'){
            $result= $calculatorService->sum($a, $b);
        }
        else if($operation == 'subtract'){
            $result= $calculatorService->subtract($a, $b);
        }
        else if($operation == 'multiply'){
            $result= $calculatorService->multiply($a, $b);
        }
        else if($operation == 'divide'){
            $result= $calculatorService->divide($a, $b);
        }
        $mathRepo = new MathRepository();
        $operations = $mathRepo->findAll();
        include 'Views/Calculator_View.php';
        // do operation
        //show the calculator with much data
    }
}