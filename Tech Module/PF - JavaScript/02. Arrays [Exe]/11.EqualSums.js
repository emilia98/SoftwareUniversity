function findEqualSums(str){
    let array = str.split(' ').map(el => Number(el));
    let len = array.length;

    if(len <= 1){
        console.log(0);
    }
    else{
        let hasFoundSums = false;
        let indexes = new Array(len - 2);
        let cnt = 0;

        for(let index = 0; index <= len - 1; index++){
            let leftSum = 0;
            for(let innerIndex = 0; innerIndex < index; innerIndex++){
                leftSum += array[innerIndex];
            }

            let rightSum = 0;
            for(let innerIndex = index + 1; innerIndex < len; innerIndex++){
                rightSum += array[innerIndex];
            }

            if(leftSum == rightSum){
                hasFoundSums = true;
                indexes[cnt] = index;
                cnt++;
            }
        }

        if(hasFoundSums){
            indexes = indexes.slice(0, cnt);
            console.log(indexes.join(" "));
        }
        else{
            console.log("no");
        }
    }
}

findEqualSums("1 2 3 3");
findEqualSums("1 2");
findEqualSums("1");
findEqualSums("1 2 3");
findEqualSums("10 5 5 99 3 4 2 5 1 1 4");
findEqualSums("0 0 0 0 0");