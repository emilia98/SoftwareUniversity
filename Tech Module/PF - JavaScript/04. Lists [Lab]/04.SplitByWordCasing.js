function splitByCasing(str){
    let splitString = str.split(/[,;:.!()"'\/\[\] ]/).filter(word => word != "");

    let lowerCasedWords = [];
    let mixedCasedWords = [];
    let upperCasedWords = [];

    for(let word of splitString){
        if(hasOnlyLetters(word)){
            if(word == word.toLowerCase()){
                lowerCasedWords.push(word);
            }else if(word == word.toUpperCase()){
                upperCasedWords.push(word);
            }else{
                mixedCasedWords.push(word);
            }
        }else{
            mixedCasedWords.push(word);
        }
    }

    printResult("Lower-case", lowerCasedWords);
    printResult("Mixed-case", mixedCasedWords);
    printResult("Upper-case", upperCasedWords);

    function hasOnlyLetters(word){

        for(let letter of word){
            if( (letter.charCodeAt(0) >= 0 && letter.charCodeAt(0) < 65) || (letter.charCodeAt(0) > 90 && letter.charCodeAt(0) < 97) || (letter.charCodeAt(0) > 122)){
                return false;
            }
        }
        return true;
    }

    function printResult(word, list){
        console.log(`${word}: ${list.join(', ')}`);
    }
}

splitByCasing("Learn programming at SoftUni: Java, PHP, JS, HTML 5, CSS, Web, C#, SQL, databases, AJAX, etc.");