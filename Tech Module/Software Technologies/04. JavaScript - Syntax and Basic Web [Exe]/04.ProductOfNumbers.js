function findProductOfNumbers(arr){
    let nums = arr.map(el => Number(el));
    let negatives = 0;
    let hasZeroes = false;

    for (let num of nums) {
        if(num < 0){
            negatives++;
        }

        if(num == 0){
            hasZeroes = true;
        }
    }

    if(negatives % 2 == 1 && !hasZeroes){
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
*/