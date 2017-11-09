function extractSubsequence(array){
    let extractedArray = [];
    let biggestNumber = array[0];
    extractedArray[0] = biggestNumber;

    for(let index = 1; index < array.length; index++){
        let currentNumber = array[index];

        if(currentNumber >= biggestNumber){
            extractedArray.push(currentNumber);
            biggestNumber = currentNumber;
        }
    }

    for(let number of extractedArray){
        console.log(number);
    }
}

/* Uncomment to test:
extractSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]);
extractSubsequence([1, 2, 3, 4]);
extractSubsequence([20, 3, 2, 15, 6, 1,]);
*/