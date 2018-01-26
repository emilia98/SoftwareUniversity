function sumFirstAndLast(array){
    array = array.map(el => Number(el));
    let first = array[0];
    let last = array[array.length - 1];
    console.log(first + last);
}

/* Uncomment to test:
sumFirstAndLast(['20', '30', '40']);
sumFirstAndLast(['5', '10']);
*/