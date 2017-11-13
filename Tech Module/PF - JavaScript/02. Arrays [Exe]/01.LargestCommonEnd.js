function findLargestCommmonEnd(input1, input2){
    let array1 = input1.split(" ") ;
    let array2 = input2.split(' ');
    let minSize = Math.min(array1.length, array2.length);
    let maxSize = Math.max(array1.length, array2.length);

    let commonStartCounter = findCommonStart(array1, array2, minSize);
    let commonEndCounter = findCommonEnd(array1, array2, minSize);

    if(commonStartCounter > commonEndCounter){
        console.log(commonStartCounter);
    }
    else{
        console.log(commonEndCounter);
    }

    function findCommonStart(array1, array2, minSize){
        let countCommonStart = 0;

        for(let index = 0; index < minSize; index++){
            if(array1[index] != array2[index]){
                break;
            }
            countCommonStart++;
        }
        return countCommonStart;
    }

    function findCommonEnd(array1, array2, minSize){
        let countCommonEnd = 0;
        let size1 = array1.length;
        let size2 = array2.length;

        let index = 0;
        while(index < minSize){
            if(array1[size1 - 1 - index] != array2[size2 - 1 - index]){
                break;
            }
            index++;
            countCommonEnd++;
        }
        return countCommonEnd;
    }
}

// Uncomment to test:
findLargestCommmonEnd( "hi php java csharp sql html css js",
                       "hi php java js softuni nakov java learn");
findLargestCommmonEnd("hi php java xml csharp sql html css js",
                       "nakov java sql html css js");
findLargestCommmonEnd("I love programming", "Learn Java or C#");
findLargestCommmonEnd("php nakov java sql html css js",
                      "nakov java sql html css js");