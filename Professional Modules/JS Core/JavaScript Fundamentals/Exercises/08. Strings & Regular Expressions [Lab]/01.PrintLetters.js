function printLetters(str){

    for(let index = 0; index < str.length; index++){
        let letter = str[index];
        console.log(`str[${index}] -> ${letter}`);
    }
}

/* Uncomment to test:
printLetters("Hello, World!");
printLetters("SoftUni");
*/