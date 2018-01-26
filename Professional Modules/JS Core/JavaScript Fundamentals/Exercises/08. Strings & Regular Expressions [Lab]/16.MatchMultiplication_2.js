function matchMultiplication(text) {
    let pattern = /(-?[0-9]+)(\s*\*\s*)(-?[0-9]+[.0-9?]*)/g;
    let match = pattern.exec(text);

    while(match !== null){
        let num1 = Number(match[1]);
        let num2 = Number(match[3]);
        let result = num1 * num2;

        text = text.replace(match[0], result);
        match = pattern.exec(text);
    }
    console.log(text);
}

/* Uncomment to test:
matchMultiplication("My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit).");
matchMultiplication("My bill: 2*2.50 (beer); 2* 1.20 (kepab); -2  * 0.5 (deposit); 2*2.50 (beer).");
*/