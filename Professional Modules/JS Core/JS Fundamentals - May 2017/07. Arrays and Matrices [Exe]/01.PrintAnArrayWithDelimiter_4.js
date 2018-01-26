function printArray(array){
    let delimiter = array[array.length - 1];
    let result = "";
    for(let index = 0; index < array.length - 2; index++){
        result += array[index] + delimiter;
    }
    result += array[array.length - 2];
    console.log(result);
}

/*Uncomment to test:
printArray(["One", "Two", "Three", "Four", "Five", "-"]);
printArray(["How about no?", "I", "will", "not", "do", "it!", "_"]);
*/
