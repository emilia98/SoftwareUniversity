function findTwoSmallestElements(array){
    let smallestElements = [];
    smallestElements = getTwoSmallestElemets(smallestElements, array);
    console.log(smallestElements.join(" "));

    function getTwoSmallestElemets(smallestElements, array){
        for(let counter = 1; counter <= 2; counter++){
            let minElementInfo = findSmallestElement(array);
            smallestElements.push(minElementInfo.smallest);
            array.splice(minElementInfo.indexToRemove, 1);
        }
        return smallestElements;
    }

    function findSmallestElement(array){
        let min = array[0];
        let minIndex = 0;
        for(let index = 0; index < array.length; index++){
            if(array[index] < min){
                min = array[index];
                minIndex = index;
            }
        }
        return {smallest: min, indexToRemove: minIndex};
    }
}

/* Uncomment to test:
findTwoSmallestElements([30, 15, 50, 5]);
findTwoSmallestElements([3, 0, 10, 4, 7, 3]);
*/