function findThreeIntegersSum(str){
    let array = str[0].split(' ').map(el => parseInt(el));
    let num1 = array[0];
    let num2 = array[1];
    let num3 = array[2];

    if(num1 + num2 == num3) {
        printSum(num1, num2, num3);
    } else if(num2 + num3 == num1){
        printSum(num2, num3, num1);
    } else if(num1 + num3 == num2){
        printSum(num1, num3, num2);
    } else{
        console.log("No");
    }


    function printSum(a, b, c){
        console.log(`${Math.min(a, b)} + ${Math.max(a, b)} = ${c}`);
    }
}

/* Uncomment to test:
findThreeIntegersSum(["8 15 7"]);
findThreeIntegersSum(["-5 -3 -2"]);
findThreeIntegersSum(["3 8 12"]);
*/
