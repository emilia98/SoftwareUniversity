function countNumbers(str){
    let nums = str.split(' ').
                   map(el => parseInt(el)).
                   sort((a, b) => a > b);
    let numbers = [];
    let occurrences = [];
    let cnt = 0;

    numbers.push(nums[0]);
    occurrences.push(1);
    for(let index = 1; index < nums.length; index++){
        if(nums[index - 1] == nums[index]){
            occurrences[cnt]++;
        }else{
            numbers.push(nums[index]);
            occurrences.push(1);
            cnt++;
        }
    }

    for(let index in numbers){
        console.log(`${numbers[index]} -> ${occurrences[index]}`);
    }
}

countNumbers("8 2 2 8 2 2 3 7");
countNumbers("10 8 8 10 10");