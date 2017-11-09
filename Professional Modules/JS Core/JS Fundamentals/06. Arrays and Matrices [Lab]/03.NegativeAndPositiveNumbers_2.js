function printNumbers(array){
    array.map(el => Number(el));
    let newArray = [];

    array.forEach(num => (num < 0) ? newArray.unshift(num) : newArray.push(num));
    newArray.forEach(el => console.log(el));
}

/* Uncomment to test:
printNumbers([7, -2, 8, 9]);
printNumbers([3, -2, 0, -1]);
*/
