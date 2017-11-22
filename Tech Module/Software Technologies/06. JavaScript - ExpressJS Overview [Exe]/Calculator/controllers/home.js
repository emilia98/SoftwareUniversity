const Calculator = require('../models/Calculator');

module.exports = {
    indexGet: (req, res) => {
        res.render('home/index');
    },
    indexPost: (req, res) => {
        let calculatorBody = req.body;
        let calculatorParams = calculatorBody['calculator'];
        let calculator = new Calculator();

        calculator.leftOperand = Number(calculatorParams.leftOperand);
        calculator.operator = calculatorParams.operator;
        calculator.rightOperand = Number(calculatorParams.rightOperand);

        let result = calculator.calculateResult();

        if(isNaN(result)){
            res.render('home/errorNaN', {
                'calculator': calculator,
                'result': result
            });

        }else{
            res.render('home/index', {
                'calculator': calculator,
                'result': result
            });
        }
        //console.log(result);


    }
};