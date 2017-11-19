function printInReversedOrder(str){
    let nums = str.map(el => Number(el));

    for(let index = nums.length - 1; index >= 0; index--){
        console.log(nums[index]);
    }
}

/* Uncomment to test:
printInReversedOrder(["10", "15", "20"]);
printInReversedOrder(["5", "5.5", "24", "-3"]);
printInReversedOrder(["20", "1", "20", "1", "20"]);
*/
