function sortNumbers(str){
    let nums = str.split(' ').map(Number);

    let sortedNums = [];
    sortedNums.push(nums[0]);
    let min = nums[0];
    let max = nums[0];

    for(let index = 1; index < nums.length; index++){
        let currentNum = nums[index];

        if(currentNum <= min){
            sortedNums.unshift(currentNum);
            min = currentNum;
        }else if(currentNum >= max){
            sortedNums.push(currentNum);
            max = currentNum;

        }else if(sortedNums.length == 2) {
            sortedNums.splice(1, 0, currentNum);
        }else{
            let len = sortedNums.length;
            let hasSmaller = true;
            let cnt = 1;

            for(let cnt = len - 2; cnt >= 1; cnt--){
                let previous = sortedNums[cnt + 1];
                let next = sortedNums[cnt - 1];

                if( (currentNum <= previous)
                    && (currentNum >= next)){
                    sortedNums.splice(cnt, 0, currentNum);
                    break;
                }
            }
        }
    }

    console.log(sortedNums.join(" <= "));
}

sortNumbers("8 2 7 3");
sortNumbers("2 4 -9");
sortNumbers("12 1 9 4 16 8 25 49 16");