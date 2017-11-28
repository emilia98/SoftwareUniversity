function printSquareNumbers(str){
    let nums = str.split(' ').
                   map(el => parseInt(el)).
                   filter(el => Math.sqrt(el) == parseInt(Math.sqrt(el))).
                   sort((a, b) => a < b);

    console.log(nums.join(" "));
}

printSquareNumbers("3 16 4 5 6 8 9 ");
printSquareNumbers("12 1 9 4 16 8 25 49 16");