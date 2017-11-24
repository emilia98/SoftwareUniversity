function jumpAround(str){
    let nums = str.split(' ').map(el => parseInt(el));

    let size = nums.length;
    let collectedSum = nums[0];
    let currentIndex = 0;
    let hasSuccessful = false;

    while(true){
        let positions = nums[currentIndex];
        let index = 0;

        let subtractValue = currentIndex - positions;
        let sumValue = currentIndex + positions;

        if(sumValue >= 0 && sumValue < size){
            hasSuccessful = true;
            index = sumValue;
        }
        else if(subtractValue >= 0 && subtractValue < size){
            hasSuccessful = true;
            index = subtractValue;
        }

        if(hasSuccessful){
            collectedSum += nums[index];
            currentIndex = index;
        }else{
            break;
        }
        hasSuccessful = false;
    }

    console.log(collectedSum);
}

jumpAround("3 7 12 2 10");
jumpAround("10 50 7 30 8 5");
jumpAround("2 3 5 7 5 4 8 4");