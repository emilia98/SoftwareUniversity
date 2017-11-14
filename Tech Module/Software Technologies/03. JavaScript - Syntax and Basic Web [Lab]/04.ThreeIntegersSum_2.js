function findThreeIntegersSum(str){
    let array = str[0].split(' ').map(el => parseInt(el));
    console.log(checkNumbers(array[0], array[1], array[2]) ||
        checkNumbers(array[0], array[2], array[1]) ||
        checkNumbers(array[1], array[2], array[0]) ||
        "No");

    function checkNumbers(num1, num2, sum){
        if(num1 + num2 != sum){
            return false;
        }

        return `${Math.min(num1, num2)} + ${Math.max(num1, num2)} = ${sum}`;
    }
}

/* Uncomment to test:
findThreeIntegersSum(["8 15 7"]);
findThreeIntegersSum(["-5 -3 -2"]);
findThreeIntegersSum(["3 8 12"]);
*/

