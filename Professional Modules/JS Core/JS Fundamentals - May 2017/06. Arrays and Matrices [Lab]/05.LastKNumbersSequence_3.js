function printSequence(n, k){
    let sequence = [1];

    for(let counter = 1; counter < n; counter++){
        let startIndex = counter - 1;
        let endIndex = counter - k;

        if(endIndex < 0){
            endIndex = 0;
        }

        let sum = 0;
        for(let index = startIndex; index >= endIndex; index--){
            sum += sequence[index];
        }

        sequence[counter] = sum;
    }
    console.log(sequence.join(" "));
}

/* Uncomment to test:
printSequence(6, 3);
printSequence(8, 2);
printSequence(9, 5);
printSequence(1, 1);
*/