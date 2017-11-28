function countNumbers(str){
    let nums = str.split(' ').map(el => parseInt(el));

    nums = nums.sort((a, b) => a > b);
    let numbers = [];
    let occurrences = [];
    let cnt = 0;

    for(let index = 0; index < nums.length; index++){
        let occurrenceIndex = numbers.indexOf(nums[index]);
        if(occurrenceIndex == -1){
            numbers.push(nums[index]);
            occurrences.push(1);
            cnt++;
        }else{
            occurrences[occurrenceIndex]++;
        }

    }

    for(let index in numbers){
        console.log(`${numbers[index]} -> ${occurrences[index]}`);
    }
}

countNumbers("8 2 2 8 2 2 3 7");
countNumbers("10 8 8 10 10");