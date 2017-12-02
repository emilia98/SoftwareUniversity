function bombNumbers(str1, str2){
    let nums = str1.split(' ').map(Number);
    let bombParams = str2.split(' ').map(Number);

    let bomb = bombParams[0];
    let power = bombParams[1];

    for(let index = 0; index < nums.length; index++) {
        if (bomb == nums[index]) {
            let elementsInLeft = index;
            let elementsInRight = nums.length - index - 1;
            let removed = 1;

            if (elementsInLeft > 0) {
                let startLeft = index - power;
                let endLeft = power;
                if (elementsInLeft < power) {
                    startLeft = 0;
                    endLeft = elementsInLeft;
                }
                removed = index - startLeft;
                nums.splice(startLeft, endLeft);
                index -= removed;
            }
            nums.splice(index, 1);
            removed = 1;

            index -= removed;
            if (elementsInRight > 0) {
                let startRight = index + 1;
                let endRight = power;
                if (elementsInRight < power) {
                    startRight = Math.min(startRight, nums.length);
                    endRight = Math.min(elementsInRight, nums.length);
                }
                nums.splice(startRight, endRight);
            }
        }
    }

    let sum = 0;
    for(let index = 0; index < nums.length; index++){
        sum += nums[index];
    }
    console.log(sum);
}

bombNumbers("1 2 2 4 2 2 2 9", "4 2");
bombNumbers("1 7 7 1 2 3", "7 1");
bombNumbers("1 4 4 2 8 9 1", "9 3");
bombNumbers("1 1 2 1 1 1 2 1 1 1", "2 1");
bombNumbers("2 3 5 6", "2 2");
bombNumbers("1 2 3 4 5", "3 3");










