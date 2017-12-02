function searchForANumber(str1, str2){
    let nums = str1.split(' ').map(Number);
    let searchingParams = str2.split(' ').map(Number);

    let numsToTake = searchingParams[0];
    let numsToDelete = searchingParams[1];
    let numToFind = searchingParams[2];

    nums = takeNumbers(nums, numsToTake);
    nums = deleteNumbers(nums, numsToDelete);

    let hasFound = findNumber(nums, numToFind);

    hasFound == true ? console.log("YES!") : console.log("NO!");

    function takeNumbers(nums, count){
        let takenNums = [];

        for(let index = 0; index < count; index++){
            takenNums.push(nums[index]);
        }
        return takenNums;
    }

    function deleteNumbers(nums, count){
        let numsLeft = [];

        for(let index = count; index < nums.length; index++){
            numsLeft.push(nums[index]);
        }
        return numsLeft;
    }

    function findNumber(nums, numToFind){
        for (let num of nums) {
            if(num == numToFind){
                return true;
            }
        }
        return false;
    }
}

searchForANumber("1 2 3 4 5 6","5 2 3");
searchForANumber("12 412 123 21 654 34 65 3 23","7 4 21");