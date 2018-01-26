function printNumbers(array){
    array = array.map(el => Number(el));
    let n = array[0];
    let numbers = array.slice(1, array.length);

    console.log(numbers.slice(0, n).join(" "));
    console.log(numbers.slice(array.length - n - 1).join(" "));
}

/* Uncomment to test:
printNumbers([2, 7, 8, 9]);
printNumbers([3, 6, 7, 8, 9]);
printNumbers([5, 1, 78, 45, 41, 4125, 12]);
*/

