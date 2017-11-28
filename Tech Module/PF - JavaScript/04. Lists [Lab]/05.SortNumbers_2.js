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

            for(let cnt = 0; cnt < len; cnt++){
                let prev = sortedNums[cnt];
                let next = sortedNums[cnt + 1];

                if(currentNum >= prev && currentNum <= next){
                    sortedNums.splice(cnt + 1, 0, currentNum);
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
sortNumbers("3 16 4 5 6 8 9");