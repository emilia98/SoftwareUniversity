function printSequence(n,  k){
    let sequence = [1, 1];

    if(n <= 2){
        console.log(sequence.slice(0, n).join(" "));
    }
    else{
        for(let counter = 2; counter < n; counter++){
            let startIndex = counter - k;

            if(startIndex < 0){
                startIndex = 0;
            }
            arrayToSum = sequence.slice(startIndex);

            let nextElement = arrayToSum.reduce((a, b) => a + b);
            sequence.push(nextElement);
        }
        console.log(sequence.join(" "));
    }
}

/* Uncomment to test:
printSequence(6, 3);
printSequence(8, 2);
printSequence(9, 5);
printSequence(3, 7);
printSequence(7, 1);
printSequence(4, 3);
*/

