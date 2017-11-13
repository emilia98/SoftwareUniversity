function foldAndSum(str){
    let array = str.split(' ').map(el => parseInt(el));
    let k = parseInt(array.length / 4);
    let arr1 = new Array(2 * k);
    let arr2 = new Array(2 * k);

    let arrPartOne = getArrayAndReverse(k, 0, array);
    let arrPartTwo = getArrayAndReverse(k, 3 * k, array);

    arr1 = arrPartOne.concat(arrPartTwo);
    arr2 = array.slice(k, 3 * k);

    let summedArray = sumArrays(arr1, arr2);

    console.log(summedArray.join(" "));

    function  getArrayAndReverse(k, startIndex, array) {
        let newArray = new Array(k);
        let counter = 0;
        for(let index = startIndex; index < startIndex + k; index++){
            newArray[counter] = array[index];
            counter++;
        }
        return newArray.reverse();
    }

    function sumArrays(arr1, arr2){
        let newArray = new Array(arr1.length);

        for(let index = 0; index < arr1.length; index++) {
            newArray[index] = arr1[index] + arr2[index];
        }
        return newArray;
    }
}

foldAndSum("5 2 3 6");
foldAndSum("1 2 3 4 5 6 7 8");
foldAndSum("4 3 -1 2 5 0 1 9 8 6 7 -2");