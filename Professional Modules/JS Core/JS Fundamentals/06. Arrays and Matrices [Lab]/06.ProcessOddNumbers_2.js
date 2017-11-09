function processOddNumbers(array){
    array = array.map(el => Number(el));

    let modifiedArray = [];
    modifiedArray = getNumbersOnOddIndexes(array, modifiedArray);
    modifiedArray = doubleNumbers(modifiedArray);
    modifiedArray = reverseArray(modifiedArray);

    console.log(modifiedArray.join(" "));

    function getNumbersOnOddIndexes(array, newArray){
        for(let index = 0; index < array.length; index++){
            if(index % 2 != 0){
                newArray.push(array[index]);
            }
        }
        return newArray;
    }

    function doubleNumbers(numbers){
        for(let i in numbers){
            numbers[i] *= 2;
        }
        return numbers;
    }

    function reverseArray(numbers){
        let newArray = [];
        for(let index = numbers.length - 1; index >= 0; index--){
            newArray.push(numbers[index]);
        }
        return newArray;
    }
}

/* Uncomment to test:
processOddNumbers([10, 15, 20, 25]);
processOddNumbers([3, 0, 10, 4, 7, 3]);
*/
