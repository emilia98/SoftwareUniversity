function modifyAverage(arg){
    let number = arg.toString();
    let sumDigits = 0;

    for(let index = 0; index < number.length; index++){
        sumDigits += parseInt(number[index]);
    }

    let digitsToAdd = 0;
    digitsToAdd = getCountOfNinesToAdd(sumDigits, number);
    let resultedNumber = number + "9".repeat(digitsToAdd);
    console.log(resultedNumber);

    function getCountOfNinesToAdd(sumDigits, number ){
        let digitsToAdd = 0;
        let average = sumDigits / number.length;

        while(average <= 5){
            sumDigits += 9;
            digitsToAdd++;
            average = sumDigits / (number.length + digitsToAdd);
        }
        return digitsToAdd;
    }
}

/* Uncomment to test:
modifyAverage(101);
modifyAverage(5835);
*/