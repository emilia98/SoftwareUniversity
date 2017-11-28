function printSquareNumbers(str){
    let nums = str.split(' ').map(el => parseInt(el));

    let squareNumbers = [];
    for(let num of nums){
        if(Math.sqrt(num) == parseInt(Math.sqrt(num))){
            squareNumbers.push(num);
        }
    }

    squareNumbers.sort((a, b) => b > a);
    console.log(squareNumbers.join(" "));
}

printSquareNumbers("3 16 4 5 6 8 9 ");
printSquareNumbers("12 1 9 4 16 8 25 49 16");