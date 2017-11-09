function printArray(array){
    let delimiter = array[array.length - 1];
    let newArray = array.slice(0, array.length - 1);
    console.log(newArray.join(delimiter));
}

/* Uncomment to test:
printArray(["One", "Two", "Three", "Four", "Five", "-"]);
printArray(["How about no?", "I", "will", "not", "do", "it!", "_"]);
*/