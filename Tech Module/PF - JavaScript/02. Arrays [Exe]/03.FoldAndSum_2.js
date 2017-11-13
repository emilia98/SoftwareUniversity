function foldAndSum(str){
    let array = str.split(' ').map(el => parseInt(el));
    let k = parseInt(array.length / 4);
    let arr1 = new Array(2 * k);
    let arr2 = new Array(2 *k);

    let arrPartOne = array.slice(0, k).reverse();
    let arrPartTwo = array.slice(3 * k, 4 * k).reverse();

    arr1 = arrPartOne.concat(arrPartTwo);
    arr2 = array.slice(k, 3 * k);

    let summedArray = new Array(2 * k);
    for(let index = 0; index < 2 * k; index++){
        summedArray[index] = arr1[index] + arr2[index];
    }

    console.log(summedArray.join(" "));
}

foldAndSum("5 2 3 6");
foldAndSum("1 2 3 4 5 6 7 8");
foldAndSum("4 3 -1 2 5 0 1 9 8 6 7 -2");