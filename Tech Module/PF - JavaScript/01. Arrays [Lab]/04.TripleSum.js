function checkForTripleSum(array){
    array = array.map(el => Number(el));
    let hasTripleSum = false;
    let last = array.length;

    for(let ind1 = 0; ind1 < last; ind1++){
        let a = array[ind1];
        for(let ind2 = ind1 + 1; ind2 < last; ind2++){
            let b = array[ind2];
            for(let ind3 = 0; ind3 < last; ind3++){
                let c = array[ind3];

                if(a + b === c){
                    hasTripleSum = true;
                    console.log(`${a} + ${b} == ${c}`);
                    break;
                }
            }
        }
    }

    if(!hasTripleSum){
        console.log("No");
    }
}

checkForTripleSum([1, 1, 1, 1]);
checkForTripleSum([4, 2, 8, 6]);
checkForTripleSum([2, 7, 5, 0]);
checkForTripleSum([3, 1, 5, 6, 1, 2]);
checkForTripleSum([1, 1, 0, 2]);