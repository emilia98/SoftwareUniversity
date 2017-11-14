function printAllSymmetricNumbers(str){
    let num = parseInt(str[0]);
    let symmetricNumbers = [];

    for(let cnt = 1; cnt <= num; cnt++){
        if(isSymmetric(cnt)){
            symmetricNumbers.push(cnt);
        }
    }

    console.log(symmetricNumbers.join(" "));

    function isSymmetric(number){
        let numberAsString = number.toString();
        let size = numberAsString.length;
        let endIndex = parseInt(size / 2);

        for(let index = 0; index <= endIndex; index++){
            if(numberAsString[index] != numberAsString[size - 1 - index]){
                return false;
            }
        }
        return true;
    }
}

/* Uncomment to test:
printAllSymmetricNumbers(["100"]);
printAllSymmetricNumbers(["750"]);
*/