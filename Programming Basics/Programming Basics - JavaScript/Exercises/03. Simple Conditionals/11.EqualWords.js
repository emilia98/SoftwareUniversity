function compareWords([arg1, arg2]){
    let firstWord = arg1;
    let secondWord = arg2;

    firstWord = firstWord.toLowerCase();
    secondWord = secondWord.toLowerCase();

    if(firstWord ==  secondWord){
        console.log("yes");
    }
    else{
        console.log("no");
    }
}

/* Uncomment to test:
compareWords(["Hello", "Hello"]);
compareWords(["SoftUni", "softuni"]);
compareWords(["Soft", "Uni"]);
compareWords(["beer", "vodka"]);
compareWords(["HeLlO", "hELLo"]);
    */