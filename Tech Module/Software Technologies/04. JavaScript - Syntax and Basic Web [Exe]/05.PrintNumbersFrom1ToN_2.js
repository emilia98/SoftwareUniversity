function printNumbers(str){
    let n = Number(str[0]);
    let numbers = new Array(n);

    numbers.fill(0);
    numbers.forEach((el, i) => console.log(i + 1));
}

/* Uncomment to test:
printNumbers(["5"]);
printNumbers(["2"]);
*/