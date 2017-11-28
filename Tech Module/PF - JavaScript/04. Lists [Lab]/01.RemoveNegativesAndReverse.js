function removeNegativesAndReverse(str){
    let nums = str.split(' ').map(el => parseInt(el));
    let nonNegatives = [];

    nonNegatives = getNonNegatives(nums);

    if(nonNegatives.length == 0){
        console.log("empty");
    } else{
        nonNegatives = reverseNonNegatives(nonNegatives);
        console.log(nonNegatives.join(" "));
    }

    function getNonNegatives(list){
        let nonNegatives = [];
        for (let num of nums)
        {
            if(num >= 0){
                nonNegatives.push(num);
            }
        }
        return nonNegatives;
    }

    function reverseNonNegatives(list){
        let reversedList = [];
        for(let index = list.length - 1; index >= 0; index--){
            reversedList.push(list[index]);
        }
        return reversedList;
    }
}

removeNegativesAndReverse("10 -5 7 9 -33 50");
removeNegativesAndReverse("7 -2 -10 1");
removeNegativesAndReverse("-1 -2 -3");