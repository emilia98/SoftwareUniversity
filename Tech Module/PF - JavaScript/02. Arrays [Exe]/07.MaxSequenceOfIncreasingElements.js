function findMaxSequenceOfIncreasingElements(str){
    let array = str.split(' ').map(el => parseInt(el));
    let maxSequence = new Array(array.length);
    let currentSequence = new Array(array.length);

    maxSequence[0] = array[0];
    currentSequence[0] = array[0];

    let currentSize = 1;
    let maxSeqSize = 1;

    for(let index = 1; index < array.length; index++){
        if(array[index - 1] < array[index]){
            currentSequence[currentSize] = array[index];
            currentSize++;
        }
        else{
            if(currentSize > maxSeqSize){
                maxSequence = currentSequence.slice(0);
                maxSeqSize = currentSize;
            }
            currentSequence = [];
            currentSequence[0] = array[index];
            currentSize = 1;
        }
    }

    if(currentSize > maxSeqSize){
        maxSequence = currentSequence.slice(0);
    }

    console.log(maxSequence.join(" "));
}

findMaxSequenceOfIncreasingElements("3 2 3 4 2 2 4");
findMaxSequenceOfIncreasingElements("4 5 1 2 3 4 5");
findMaxSequenceOfIncreasingElements("3 4 5 6");
findMaxSequenceOfIncreasingElements("0 1 1 2 2 3 3");
