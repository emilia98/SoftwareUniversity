function searchForANumber(str1, str2){
    let nums = str1.split(' ').map(Number);
    let searchingParams = str2.split(' ').map(Number);

    let numsToTake = searchingParams[0];
    let numsToDelete = searchingParams[1];
    let numToFind = searchingParams[2];

    nums = nums.slice(0, numsToTake).splice(numsToDelete);

    if(nums.indexOf(numToFind) == -1){
        console.log("NO!");
    }else{
        console.log("YES!");
    }
}

searchForANumber("1 2 3 4 5 6","5 2 3");
searchForANumber("12 412 123 21 654 34 65 3 23","7 4 21");