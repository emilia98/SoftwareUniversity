function printArray(array){
    let delimiter = array[array.length - 1];
    array.pop();

    let result = "";

    for(let index = 0; index < array.length; index++){
        if(index == array.length - 1){
            result += array[index];
        }
        else{
            result += array[index] + delimiter;
        }
    }
    console.log(result);
}

/* Uncomment to test:
printArray(["One", "Two", "Three", "Four", "Five", "-"]);
printArray(["How about no?", "I", "will", "not", "do", "it!", "_"]);
*/
