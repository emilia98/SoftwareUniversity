<?php

class MathRepository
{
    private $operations = [
        'sum' => 'Сумирай',
        'subtract' => 'Извади',
        'divide' => 'Раздели',
        'multiply' => 'Умножи'
    ];

    /**
     * @return MathOperation[]
     */
    public function findAll() :array{
        $mathOperations = [];
        foreach($this->operations as $funcName => $displayName){
            $operation = new MathOperation($funcName, $displayName);
            $mathOperations[] = $operation;
        }
        return $mathOperations;
    }

    public function findByName(string $name) :MathOperation{
        return new MathOperation($name, $this->operations[$name]);
    }
}