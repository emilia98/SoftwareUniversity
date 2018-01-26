function splitExpression(expr){
    let pattern = /[;,.)(\t\r\s]+/g;
    let matches = expr.split(pattern);

    matches.filter(m => m != "").forEach(el => console.log(el));
}

/* Uncomment to test:
splitExpression('let    sum = 4 * 4,let b = "wow"; "as5"');
splitExpression('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}');
splitExpression('let sum = 4 * 4,    let b = "wow""; "as5"" ""asf""');
*/

