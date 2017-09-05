function findGreaterNumber([arg1, arg2]){
    let a = parseInt(arg1);
    let b = parseInt(arg2);

    if(a > b){
        console.log(a);
    }else{
        console.log(b);
    }
}

/* Uncomment to test:
findGreaterNumber(["5", "3"]);
findGreaterNumber(["3", "5"]);
findGreaterNumber(["10", "10"]);
findGreaterNumber(["-5", "5"]);
*/