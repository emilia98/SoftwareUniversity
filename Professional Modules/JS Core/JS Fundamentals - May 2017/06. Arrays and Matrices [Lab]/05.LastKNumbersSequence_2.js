function printSequence(n,  k){
    let sequence = [1];

    for(let counter = 1; counter < n; counter++){
        let startPosition = counter - k;

        if(startPosition < 0){
            startPosition = 0;
        }
        let sum = sequence.slice(startPosition).reduce( (a, b) => a + b);
        sequence.push(sum);
    }
    console.log(sequence.join(" "));
}

/* Uncomment to test:
printSequence(6, 3);
printSequence(8, 2);
printSequence(9, 5);
printSequence(3, 7);
printSequence(7, 1);
printSequence(4, 3);
*/

