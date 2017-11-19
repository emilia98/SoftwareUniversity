function multiplyOrDivide(arr){
    let num1 = Number(arr[0]);
    let num2 = Number(arr[1]);

    if(num1 > num2){
        console.log(num1 / num2);
    }else{
        console.log(num1 * num2);
    }
}

/* Uncomment to test:
multiplyOrDivide(["2", "3"]);
multiplyOrDivide(["13", "13"]);
multiplyOrDivide(["3", "2"]);
multiplyOrDivide(["144", "12"]);
*/