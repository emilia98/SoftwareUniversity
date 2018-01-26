function modifyAverage(number){
    let inputToString = number.toString();
    let digits = inputToString.split("");
    digits = digits.map(x => parseInt(x));

    let digitsCount = digits.length;
    let sumDigits = digits.reduce((a, b) => a + b);
    let average = sumDigits / digitsCount;

    let digitsToAdd = getCountOfNinesToAdd(sumDigits, digitsCount);
    let resultedNumber = number + "9".repeat(digitsToAdd);
    console.log(resultedNumber);

    function getCountOfNinesToAdd(sumDigits, digitsCount){
        let digits = 0;
        let average = sumDigits / digitsCount;

        while(average <= 5){
            sumDigits += 9;
            digits++;
            average = sumDigits / (digitsCount + digits);
        }
        return digits;
    };
}

/* Uncomment to test:
modifyAverage(101);
modifyAverage(5835);
*/