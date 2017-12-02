function sumReversedNumbers(str){
    let nums = str.split(' ').map(el => parseFloat(el));
    let sum = 0;

    for (let num of nums) {
        let numberAsString = num.toString();
        let reversedNumber = parseFloat(reverseString(numberAsString));
        sum += reversedNumber;
    }
    console.log(sum);

    function reverseString(str){
        let reversedString = "";

        for(let index = str.length - 1; index >= 0; index--){
            reversedString += str[index];
        }
        return reversedString;
    }
}

sumReversedNumbers("123 234 12");
sumReversedNumbers("12 12 34 84 66 12");
sumReversedNumbers("120 1200 12000");
sumReversedNumbers("12.3 2.34 0.12");