function printNumbers(str) {
    let n = parseInt(str[0]);
    let nums = new Array(n);

    nums.fill(n);
    nums.forEach((el, i) => console.log(el - i));
}

/* Uncomment to test:
printNumbers(["5"]);
printNumbers(["2"]);
*/