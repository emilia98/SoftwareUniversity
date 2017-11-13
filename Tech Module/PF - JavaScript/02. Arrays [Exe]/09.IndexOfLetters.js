function printIndexOfLetters(str){
    str = str.toLowerCase();
    for(let index = 0; index < str.length; index++){
        let code = str.charCodeAt(index) - 97;
        console.log(`${str[index]} -> ${code}`);
    }
}

printIndexOfLetters("abcz");
printIndexOfLetters("softuni");