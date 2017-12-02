function findLongestSequence(str){
    nums = str.split(' ').map(Number);

    let seq = [];
    let longestSeq = [];
    seq.push(nums[0]);
    longestSeq.push(nums[0]);

    let longestSeqMax = nums[0];
    let longestSeqMin = nums[0];
    let currentSeqMin = nums[0];
    let currentSeqMax = nums[0];

    for(let index = 1; index < nums.length; index++){
        let current = nums[index];

        if(current > currentSeqMin){
            if(current > currentSeqMax){
                seq.push(current);
                currentSeqMax = current;
            } else if(current < currentSeqMax && (seq.indexOf(current) === -1)){
                seq = seq.filter(n => n < current);
                seq.push(current);
                currentSeqMax = current;
            }

            if(current > longestSeqMax){
                longestSeq.push(current);
                longestSeqMax = current;
            }else if(current < longestSeqMax && current > longestSeq[longestSeq.length - 2]) {
                if(index !== (nums.length - 1)){

                    if(hasChanceToIncrease(index + 1, current, nums)){
                        let len = longestSeq.length;
                        if(current > longestSeq[len - 2]){
                            longestSeq[len - 1] = current;
                        }
                        longestSeqMax = current;
                    }
                }
            }

            if(seq.length > longestSeq.length){
                longestSeq = [];
                longestSeq = seq.slice(0, seq.length);
                longestSeqMin = longestSeq[0];
                longestSeqMax = longestSeq[longestSeq.length - 1];
            }

        }else{
            if(seq.length > longestSeq.length){
                longestSeq = [];
                longestSeq = seq.slice(0, seq.length);
            }

            seq = [];
            seq.push(current);
            currentSeqMin = current;
            currentSeqMax = current;
        }

    }
    console.log(longestSeq.join(" "));

    function hasChanceToIncrease(startIndex, number, nums){
        if(startIndex == nums.length - 1){
            if(number < nums[startIndex]){
                return true;
            }
        }
        for(let index = startIndex; index < nums.length; index++){
            if(number < nums[index]){
                return true;
            }
        }
        return false;
    }
}

findLongestSequence("1"); // 1
findLongestSequence("7 3 5 8 -1 0 6 7"); // 3, 5, 6, 7
findLongestSequence("1 2 5 3 5 2 4 1"); // 1, 2, 3, 5
findLongestSequence("0 10 20 30 40 1 50 2 3 4 5 6"); //0 1 2 3 4 5 6
findLongestSequence("11 12 13 3 14 4 15 5 6 7 8 7 16 9 8"); // 3 4 5 6 7 8 16
findLongestSequence("3 14 5 12 15 7 8 9 11 10 1"); // 3 5 7 8 9 11
