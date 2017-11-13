function findPairsByDifference(str, n){
    let array = str.split(' ').map(el => Number(el));
    let diff = Number(n);
    let pairs = 0;

    for(let outerIndex = 0; outerIndex < array.length - 1; outerIndex++){
        let a = array[outerIndex];
        for(let innerIndex = outerIndex + 1; innerIndex < array.length; innerIndex++){
            let b = array[innerIndex];

            if(Math.abs(a - b) == diff){
                pairs++;
            }
        }
    }

    console.log(pairs);
}

findPairsByDifference("1 5 3 4 2", 2);
findPairsByDifference("5 3 8 10 12 1", 1);