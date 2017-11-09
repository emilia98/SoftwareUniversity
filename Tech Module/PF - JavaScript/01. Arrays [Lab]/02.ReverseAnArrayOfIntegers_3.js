function reverseAnArray(array){
    let reversedArray = [];
    let size = array.length;

    for(let index = 0; index < size; index++){
        reversedArray.unshift(array[index]);
    }
    console.log(reversedArray.join(" "));
}

reverseAnArray([10, 20, 30]);
reverseAnArray([-1, 20, 99, 5]);