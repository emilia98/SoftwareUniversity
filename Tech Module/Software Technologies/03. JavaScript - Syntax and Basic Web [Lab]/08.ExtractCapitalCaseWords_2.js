function extractCapitalCaseLetters(str){
    let text = str.join();
    let pattern = /\W+/g;
    let words = text.split(pattern);
    let nonEmptyWords = words.filter(w => w.length != 0);
    let uppercasedWords = nonEmptyWords.filter(word => word === word.toUpperCase());

    console.log(uppercasedWords.join(", "));
}

/* Uncomment to test:
extractCapitalCaseLetters([
    "We start by HTML, CSS, JavaScript, JSON and REST.",
    "Later we touch some PHP, MySQL and SQL.",
    "Later we play with C#, EF, SQL Server and ASP.NET MVC.",
    "Finally, we touch some Java, Hibernate and Spring.MVC."]);
*/

