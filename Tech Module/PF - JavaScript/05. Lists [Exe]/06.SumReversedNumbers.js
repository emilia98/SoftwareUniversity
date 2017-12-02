function sumReversedNumbers(str){
    let nums = str.split(' ').map(Number);
    let sum = 0;

    for (let num of nums) {
        let reversedDigits = findAndReverseDigits(num);
        let reversedNumber = Number(reversedDigits.join(''));

        sum += reversedNumber;
    }
    console.log(sum);

    function findAndReverseDigits(num){
        let digits = num.toString().split('');
        let reversedDigits = [];

        for(let index = digits.length - 1; index >= 0; index--){
            reversedDigits.push(digits[index]);
        }
        return reversedDigits;
    }
}

sumReversedNumbers("123 234 12");
sumReversedNumbers("12 12 34 84 66 12");
sumReversedNumbers("120 1200 12000");
sumReversedNumbers("12.3 2.34 0.12");