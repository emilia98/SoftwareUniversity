function matchMultiplication(text) {
    let pattern = /-?[0-9]+\s*\*\s*-?[0-9]+[.0-9?]*/g;
    let matches = text.match(pattern);

    for (let match of matches) {
        let splitMatch = match.split(/(\s*\*\s*)/);

        let num1 = Number(splitMatch[0]);
        let num2 = Number(splitMatch[2]);
        let result = num1 * num2;

        text = text.replace(match, result);
    }
    console.log(text);
}

/* Uncomment to test:
matchMultiplication("My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).");
matchMultiplication("My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit); 2*2.50 (beer).");
*/