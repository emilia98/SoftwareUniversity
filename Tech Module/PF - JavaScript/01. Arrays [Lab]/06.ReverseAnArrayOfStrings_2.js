// Here I choose to have an input as a string, not as an array
function reverseArray(input) {
    let array = input.split(' ');
    let n = array.length;
    let reversedArray = [];

    for (let index = n - 1; index >= 0; index--) {
        reversedArray[n - index - 1] = (array[index]);
    }
    console.log(reversedArray.join(" "));
}

reverseArray("a b c d e");
reverseArray("-1 hi ho w");