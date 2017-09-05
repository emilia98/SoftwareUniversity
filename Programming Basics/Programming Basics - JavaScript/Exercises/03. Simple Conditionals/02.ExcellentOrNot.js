function printIfExcellentOrNot([arg1]){
    let mark = Number(arg1);

    if(mark >= 5.50) {
        console.log("Excellent!");
    }else{
        console.log("Not excellent.");
    }
}

/* Uncomment to test:
printIfExcellentOrNot(["6"]);
printIfExcellentOrNot(["5"]);
printIfExcellentOrNot(["5.50"]);
printIfExcellentOrNot(["5.49"]);
*/
