function extractCapitalCaseLetters(str){
    let pattern = /[A-Z][a-zA-Z]*/g;
    let uppercasedWords = [];

    for(let index = 0; index < str.length; index++){
        let words = str[index].match(pattern);

        for(let word of words){
            if(word === word.toUpperCase()){
                uppercasedWords.push(word);
            }
        }
    }
    console.log(uppercasedWords.join(", "));
}

/* Uncomment to test:
extractCapitalCaseLetters([
    "We start by HTML, CSS, JavaScript, JSON and REST.",
    "Later we touch some PHP, MySQL and SQL.",
    "Later we play with C#, EF, SQL Server and ASP.NET MVC.",
    "Finally, we touch some Java, Hibernate and Spring.MVC."]);
*/
