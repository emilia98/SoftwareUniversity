function splitExpression(expr){
    let elements = expr.split(/[\s.();,]+/);
    console.log(elements.join("\n"));
}

/* Uncomment to test:
splitExpression('let    sum = 4 * 4,let b = "wow"; "as5"');
splitExpression('let sum = 1 + 2;if(sum > 2){\tconsole.log(sum);}');
splitExpression('let sum = 4 * 4,    let b = "wow""; "as5"" ""asf""');
*/

