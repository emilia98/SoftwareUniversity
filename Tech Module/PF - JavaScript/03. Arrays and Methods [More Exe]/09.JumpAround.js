function jumpAround(str){
    let nums = str.split(' ').map(el => parseInt(el));

    let size = nums.length;
    let collectedSum = nums[0];
    let currentIndex = 0;
    let hasSuccessful = false;

    while(true){
        let positions = nums[currentIndex];

        let index = currentIndex;
        index += positions;

        if( index >= 0 && index  < size){
            collectedSum += nums[index];
            hasSuccessful = true;
            currentIndex = index;
        }

        index = currentIndex;
        index -= positions;

        if( index >= 0 && index  < size && (!hasSuccessful)){
            collectedSum += nums[index];
            hasSuccessful = true;
            currentIndex = index;
        }

        if(!hasSuccessful){
            break;
        }

        hasSuccessful = false;
    }

    console.log(collectedSum);
}

jumpAround("3 7 12 2 10");
jumpAround("10 50 7 30 8 5");
jumpAround("2 3 5 7 5 4 8 4");