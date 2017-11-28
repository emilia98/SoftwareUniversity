function removeNegativesAndReverse(str){
    let nums = str.split(' ').
                   map(el => parseInt(el)).
                   filter(el => el >= 0).
                   reverse();

    if(nums.length == 0){
        console.log("empty");
    } else{
        console.log(nums.join(' '));
    }
}

removeNegativesAndReverse("10 -5 7 9 -33 50");
removeNegativesAndReverse("7 -2 -10 1");
removeNegativesAndReverse("-1 -2 -3");