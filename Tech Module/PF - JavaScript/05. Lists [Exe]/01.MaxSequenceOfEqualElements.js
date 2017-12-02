function findMaxSequence(str){
    let nums = str.split(' ').map(el => parseInt(el));

    let maxSequenceOfEqual = [];
    let currentSeq = [];
    maxSequenceOfEqual.push(nums[0]);
    currentSeq.push(nums[0]);
    let countInSeq = 1;
    let countInMaxSeq = 1;

    for(let index = 1; index < nums.length; index++){
        if(nums[index] == currentSeq[0]){
            currentSeq.push(nums[index]);
            countInSeq++;
        }else{
            if(countInSeq > countInMaxSeq){
                maxSequenceOfEqual = checkForMaxSequence(maxSequenceOfEqual,currentSeq);
            }
            currentSeq = [];
            currentSeq.push(nums[index]);
            countInSeq = 1;
        }
    }

    if(countInSeq > countInMaxSeq) {
        maxSequenceOfEqual = checkForMaxSequence(maxSequenceOfEqual, currentSeq);
    }

    console.dir(maxSequenceOfEqual);

    function checkForMaxSequence(currentMaxSeq, currentSeq){
        let currentCounter = currentSeq.length;
        let maxSeqCounter = currentMaxSeq.length;
        let maxSequence = currentMaxSeq.slice(0, maxSeqCounter);

        if(currentCounter > maxSeqCounter){
            maxSequence = currentSeq.slice(0, countInSeq);
        }
        return maxSequence;
    }
}

findMaxSequence("3 4 4 5 5 5 2 2");
findMaxSequence("7 7 4 4 5 5 3 3");
findMaxSequence("1 2 3 3");
