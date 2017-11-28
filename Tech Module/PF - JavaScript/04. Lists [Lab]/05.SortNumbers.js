function sortNumbers(str){
    let nums = str.split(' ').map(Number).
                              sort((a, b) => a > b);

    console.log(nums.join(" <= "));
}

sortNumbers("8 2 7 3");
sortNumbers("2 4 -9");
sortNumbers("12 1 9 4 16 8 25 49 16");