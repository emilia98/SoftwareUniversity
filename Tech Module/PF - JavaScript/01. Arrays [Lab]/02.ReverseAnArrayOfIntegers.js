function reverseAnArray(array){
    let reversedArray = [];

    for(let index = array.length - 1; index >= 0; index--){
        reversedArray.push(array[index]);
    }
    console.log(reversedArray.join(" "));
}

reverseAnArray([10, 20, 30]);
reverseAnArray([-1, 20, 99, 5]);