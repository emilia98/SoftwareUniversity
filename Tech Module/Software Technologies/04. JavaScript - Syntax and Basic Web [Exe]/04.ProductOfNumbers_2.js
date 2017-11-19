function findProductOfNumbers(arr){
    let nums = arr.map(el => Number(el));

    let nonPositive = nums.filter(num => num <= 0);
    let zeroes = nonPositive.filter(num => num == 0);

    if(nonPositive.length % 2 == 1 && zeroes.length == 0){
        console.log("Negative");
    }else{
        console.log("Positive");
    }
}

/* Uncomment to test:
findProductOfNumbers(["2", "3", "-1"]);
findProductOfNumbers(["5", "4", "3"]);
findProductOfNumbers(["-3", "-4", "5"]);
findProductOfNumbers(["2", "0", "-1"]);
findProductOfNumbers(["-2", "0", "-1"]);
*/
