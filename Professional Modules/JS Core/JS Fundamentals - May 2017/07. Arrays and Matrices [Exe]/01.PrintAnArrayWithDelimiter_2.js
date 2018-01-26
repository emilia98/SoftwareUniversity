function printArray(array){
    let delimiter = array[array.length - 1];
    array.pop();
    console.log(array.join(delimiter));
}

/* Uncomment to test:
printArray(["One", "Two", "Three", "Four", "Five", "-"]);
printArray(["How about no?", "I", "will", "not", "do", "it!", "_"]);
*/

