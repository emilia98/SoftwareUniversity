function findIfThreeNumbersAreEqual([arg1, arg2, arg3]){
    let a = Number(arg1);
    let b = Number(arg2);
    let c = Number(arg3);

    if(a == b && b == c){
        console.log("yes");
    }
    else{
        console.log("no");
    }
}

/* Uncomment to test:
findIfThreeNumbersAreEqual(["5", "5", "5"]);
findIfThreeNumbersAreEqual(["5", "5", "-5"]);
    */