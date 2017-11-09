// Here I choose to have an input as a string, not as an array
function reverseArray(input) {
    let array = input.split(' ');
    console.log(array.reverse().join(" "));
}

reverseArray("a b c d e");
reverseArray("-1 hi ho w");