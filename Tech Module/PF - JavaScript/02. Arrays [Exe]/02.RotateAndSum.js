function rotateAndSum(array, k){
    let rotations = k % array.length;
    let summedArray = [];

    for(let counter = 1; counter <= k; counter++){
        if(counter == 1){
            array = rotateArray(array);
            summedArray = array.slice();
        }
        else{
            array = rotateArray(array);
            summedArray = sumArrays(array, summedArray);
        }
    }

    console.log(summedArray.join(" "));

    function sumArrays(array, summedArray) {
        for(let index = 0; index < array.length; index++){
            summedArray[index] += array[index];
        }
        return summedArray;
    }

    function rotateArray(array){
        let lastElement = array.pop();
        array.unshift(lastElement);
        return array;
    }
}

rotateAndSum([3, 2, 4, -1], 2);
rotateAndSum([1, 2, 3], 1);
rotateAndSum([1, 2, 3, 4, 5], 3);