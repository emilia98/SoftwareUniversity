function concatAndReverse(array) {
    let concatenated = "";

    for(let index = 0; index < array.length; index++){
        let str = array[index];
        concatenated += str;
    }

    concatenated = reverseString(concatenated);

    console.log(concatenated);

    function reverseString(text){
        let result = "";

        for(let i = text.length - 1; i >= 0; i--){
            result += text[i];
        }

        return result;
    }
}

/* Uncomment to test:
concatAndReverse(['I', 'am', 'student']);
concatAndReverse(['race', 'car']);
*/