function grabAndGo(str, k){
    let array = str.split(' ').map(el => parseInt(el));
    let num = parseInt(k);

    let lastIndex = findLastOccurrence(array, num);

    if(lastIndex == -1){
        console.log("No occurrences were found!");
    }else{
        let sum = 0;

        for(let index = 0; index < lastIndex; index++){
            sum += array[index];
        }

        console.log(sum);
    }

    function findLastOccurrence(array, num){
        let lastIndex = -1;
        for(let index in array){
            if(array[index] == num){
                lastIndex = index;
            }
        }
        return lastIndex;
    }
}

grabAndGo("1 3 5 7 12 2 3 5 12", 3);
grabAndGo("1 2 3 4 5 6 7 8 9 10", 20);