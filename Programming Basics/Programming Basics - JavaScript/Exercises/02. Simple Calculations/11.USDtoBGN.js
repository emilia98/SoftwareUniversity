function convertUSDToBGN([arg1]){
    let dollars = parseFloat(arg1);
    let leva = dollars * 1.79549;

    console.log(`${Math.round(leva * 100)/ 100} BGN`);
}

/* Uncomment to test:
convertUSDToBGN(["20"]);
convertUSDToBGN(["100"]);
convertUSDToBGN(["12.5"]);
*/