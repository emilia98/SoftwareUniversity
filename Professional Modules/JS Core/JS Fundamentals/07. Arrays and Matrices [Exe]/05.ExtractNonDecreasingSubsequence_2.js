function extractSubsequence(array){
    let extractedArray = [];
    let maxNumIndex = findBiggestNumberIndex(array);
    extractedArray = array.filter( (num, index) => num >= array[index - 1] && maxNumIndex >= index);
    extractedArray.unshift(array[0]);
    extractedArray.forEach(el => console.log(el));

    function findBiggestNumberIndex(array){
        let maxNumber = Number.NEGATIVE_INFINITY;
        let maxNumIndex = 0;

        for(let index in array){
            if(array[index] >= maxNumber){
                maxNumber = array[index];
                maxNumIndex = index;
            }
        }
        return maxNumIndex;
    }
}

/* Uncomment to test:
extractSubsequence([1, 3, 8, 4, 10, 12, 3, 2, 24]);
extractSubsequence([1, 2, 3, 4]);
extractSubsequence([20, 3, 2, 15, 6, 1]);
extractSubsequence([3, 2, 20, 6, 20]);
*/
