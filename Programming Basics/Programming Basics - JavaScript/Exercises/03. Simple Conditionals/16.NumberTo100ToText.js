function printNumberTo100ToText([arg1]){
    let number = parseInt(arg1);
    let result = "";

    if(number >= 0 && number < 20){
        switch (number) {
            case 0: {
                result = "zero";
                break;
            }
            case 1: {
                result = "one";
                break;
            }
            case 2: {
                result = "two";
                break;
            }
            case 3: {
                result = "three";
                break;
            }
            case 4: {
                result = "four";
                break;
            }
            case 5: {
                result = "five";
                break;
            }
            case 6: {
                result = "six";
                break;
            }
            case 7: {
                result = "seven";
                break;
            }
            case 8: {
                result = "eight";
                break;
            }
            case 9: {
                result = "nine";
                break;
            }
            case 10: {
                result = "ten";
                break;
            }
            case 11: {
                result = "eleven";
                break;
            }
            case 12: {
                result = "twelve";
                break;
            }
            case 13: {
                result = "thirteen";
                break;
            }
            case 14: {
                result = "fourteen";
                break;
            }
            case 15: {
                result = "fifteen";
                break;
            }
            case 16: {
                result = "sixteen";
                break;
            }
            case 17: {
                result = "seventeen";
                break;
            }
            case 18: {
                result = "eighteen";
                break;
            }
            case 19: {
                result = "nineteen";
                break;
            }
        }
    }
    else if(number >= 20 && number < 100){
        number = number.toString();
        if(number[0] == "2"){
            result += "twenty";
        }
        else if(number[0] == "3"){
            result += "thirty";
        }
        else if(number[0] == "4"){
            result += "forty";
        }
        else if(number[0] == "5"){
            result += "fifty";
        }
        else if(number[0] == "6"){
            result += "sixty";
        }
        else if(number[0] == "7"){
            result += "seventy";
        }
        else if(number[0] == "8"){
            result += "eighty";
        }
        else if(number[0] == "9"){
            result += "ninety";
        }

        number = parseInt(number);

        if(number % 10 == 1){
            result += " one";
        }
        else if(number % 10 == 2){
            result += " two";
        }
        else if(number % 10 == 3){
            result += " three";
        }
        else if(number % 10 == 4){
            result += " four";
        }
        else if(number % 10 == 5){
            result += " five";
        }
        else if(number % 10 == 6){
            result += " six";
        }
        else if(number % 10 == 7){
            result += " seven";
        }
        else if(number % 10 == 8){
            result += " eight";
        }
        else if(number % 10 == 9){
            result += " nine";
        }
    }
    else if(number == 100){
        result = "one hundred";
    }
    else{
        result = "Invalid number"
    }

    console.log(result);
}

/* Uncomment to test:
printNumberTo100ToText(["25"]);
printNumberTo100ToText(["0"]);
printNumberTo100ToText(["10"]);
printNumberTo100ToText(["30"]);
printNumberTo100ToText(["59"]);
printNumberTo100ToText(["100"]);
printNumberTo100ToText(["-25"]);
printNumberTo100ToText(["1001"]);
*/
