function sumAdjacentEqualNumbers(str) {
    let nums = str.split(' ').map(Number);
    let result = nums.slice(0);

    while(true){
        let hasRemoved = false;
        for(let index = 1; index < result.length; index++){
            if(result[index - 1] == result[index]){
                result[index - 1] *= 2;
                result.splice(index, 1);
                hasRemoved = true;
            }
        }

        if(hasRemoved == false){
            break;
        }
    }

    console.log(result.join(" "));
}

sumAdjacentEqualNumbers("3 3 6 1");
sumAdjacentEqualNumbers("8 2 2 4 8 16");
sumAdjacentEqualNumbers("5 4 2 1 1 4");