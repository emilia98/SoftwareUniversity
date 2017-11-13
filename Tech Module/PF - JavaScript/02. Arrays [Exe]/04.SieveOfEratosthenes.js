function findPrimes(num){
    let n = parseInt(num);
    let primes = [];

    for(let index = 2; index <= n; index++){
        primes[index - 2] = index;
    }

    let currentNumber = 2;

    while(currentNumber <= n){
        for(let index = currentNumber - 1; index <= n - 2; index++){
            if(primes[index] % currentNumber == 0){
                primes[index] = 0;
            }
        }
        currentNumber++;
    }

    console.log(primes.filter(el => el != 0).join(" "));
}

findPrimes(6);
findPrimes(25);
findPrimes(1); // 1 is not prime