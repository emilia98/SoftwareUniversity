function processOddNumbers(array){
    array = array.map(el => Number(el));
    array = array.filter( (num, i) => i % 2 != 0).
                  map(num => num *= 2).
                  reverse();
    console.log(array.join(" "));
}

/* Uncomment to test:
processOddNumbers([10, 15, 20, 25]);
processOddNumbers([3, 0, 10, 4, 7, 3]);
*/