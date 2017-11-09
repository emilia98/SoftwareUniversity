// Here I choose to have an input as a string, not as an array
function reverseArray(input) {
    let array = input.split(' ');
    let n = array.length - 1;

    for (let index = 0; index <= parseInt(n / 2); index++) {
        let temp = array[index];
        array[index] = array[n - index];
        array[n - index] = temp;
    }
    console.log(array.join(" "));
}

reverseArray("a b c d e");
reverseArray("-1 hi ho w");