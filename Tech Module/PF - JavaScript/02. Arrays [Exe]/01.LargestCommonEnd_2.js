function findLargestCommmonEnd(input1, input2){
    let array1 = input1.split(" ") ;
    let array2 = input2.split(" ");
    let minSize = Math.min(array1.length, array2.length);
    let maxSize = Math.max(array1.length, array2.length);

    let commonStart = findCommonStart(array1, array2, minSize);
    let commonEnd = findCommonEnd(array1, array2, minSize);

    if(commonStart.length > commonEnd.length){
        console.log(commonStart.length);
    }
    else{
        console.log(commonEnd.length);
    }

    function findCommonStart(array1, array2, minSize){
        let commonStart = [];

        for(let index = 0; index < minSize; index++){
            if(array1[index] != array2[index]){
                break;
            }
            commonStart.push(array1[index]);
        }
        return commonStart;
    }

    function findCommonEnd(array1, array2, minSize){
        let commonEnd = [];
        let size1 = array1.length;
        let size2 = array2.length;

        let index = 0;
        while(index < minSize){
            if(array1[size1 - 1 - index] != array2[size2 - 1 - index]){
                break;
            }
            commonEnd.push(array1[size1 - 1 - index]);
            index++;
        }
        commonEnd.reverse();
        return commonEnd;
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
