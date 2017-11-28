function countNumbers(str){
    let nums = str.split(' ').map(el => parseInt(el));
    nums = nums.sort((a, b) => a > b);

    let pairs = {};
    let numsToAdd = [];

    for(let index = 0; index < nums.length; index++){
        let number = nums[index];

        if(!(number in pairs)){
            pairs[number] = 0;
            numsToAdd.push(number);
        }
        pairs[number]++;
    }

    for(let num of numsToAdd){
        console.log(`${num} -> ${pairs[num]}`);
    }
}

countNumbers("8 2 2 8 2 2 3 7");
countNumbers("10 8 8 10 10 -1");
