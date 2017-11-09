function printNumbers(array){
    array.map(el => Number(el));
    let newArray = [];

    for(let num of array){
        if(num < 0){
            newArray.unshift(num);
        }
        else{
            newArray.push(num);
        }
    }

    for(let num of newArray){
        console.log(num);
    }
}

/* Uncomment to test:
printNumbers([7, -2, 8, 9]);
printNumbers([3, -2, 0, -1]);
*/