function sumArrays(array1, array2){
    let size1 = array1.length;
    let size2 = array2.length;
    let maxSize = size1 > size2 ? size1 : size2;

    if(size1 < size2){
        let modifiedArray = modifyArray(array1, size1, maxSize);
        array1 = new Array(maxSize);
        array1 = modifiedArray;
    }
    else if(size2 < size1){
        let modifiedArray = modifyArray(array2, size2, maxSize);
        array2 = new Array(maxSize);
        array2 = modifiedArray;
    }

    let summedArray = sumArrays(array1, array2);
    console.log(summedArray.join(" "));

    function  modifyArray(array, size, maxSize) {
        let countTimes = Math.ceil(maxSize / size);
        let modifiedArray = new Array(maxSize);
        let cnt = size;
        modifiedArray = array.slice();
        let numbersAdded = size;

        for(let counter = 0; counter <= countTimes; counter++){
            for(let index = 0; index < size; index++){
                if(numbersAdded == maxSize){
                    return modifiedArray;
                }
                modifiedArray[cnt] = array[index];
                cnt++;
                numbersAdded++;
            }
        }
        return modifiedArray;
    }

    function sumArrays(array1, array2){
        let summedArray = new Array(array1.length);
        for(let index = 0; index < array1.length; index++){
            summedArray[index] = array1[index] + array2[index];
        }
        return summedArray;
    }
}

sumArrays([1, 2, 3, 4], [2, 3, 4, 5]);
sumArrays([1, 2, 3, 4, 5], [2, 3]);
sumArrays([5, 4, 3], [2, 3, 1, 4]);
sumArrays([1, 2, 3, 4, 5, 6, 7], [1, 2, 3]);