function findIfItIsEvenOrOdd([arg1]){
    let number = parseInt(arg1);

    if(number % 2 == 0) {
        console.log("even");
    }else{
        console.log("odd");
    }
}

/* Uncomment to test:
findIfItIsEvenOrOdd(["2"]);
findIfItIsEvenOrOdd(["3"]);
findIfItIsEvenOrOdd(["25"]);
findIfItIsEvenOrOdd(["1024"]);
    */