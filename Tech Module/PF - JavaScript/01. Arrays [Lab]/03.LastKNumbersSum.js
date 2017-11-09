function sumLastKNumbers(n, k){
    let sequence = [1];

    for(let counter = 1; counter < n; counter++){
        let startIndex = counter - k;

        if(startIndex < 0){
            startIndex = 0;
        }

        let sum = sequence.slice(startIndex).reduce( (a, b) => a + b);
        sequence[counter] = sum;
    }
    console.log(sequence.join(" "));
}

sumLastKNumbers(6, 3);
sumLastKNumbers(8, 2);
sumLastKNumbers(9, 5);
sumLastKNumbers(1, 1);