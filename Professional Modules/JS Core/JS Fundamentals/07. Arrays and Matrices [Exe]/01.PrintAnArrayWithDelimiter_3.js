function printArray(array){
    console.log(array.filter( (el, i) => i < array.length - 1).join(array[array.length - 1]));
}

/* Uncomment to test:
printArray(["One", "Two", "Three", "Four", "Five", "-"]);
printArray(["How about no?", "I", "will", "not", "do", "it!", "_"]);
*/

