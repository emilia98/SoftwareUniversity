function convertCelToFahr([arg1]){
    let degreesCelsuis = parseFloat(arg1);
    let degreesFahrenheit = degreesCelsuis * 1.8 + 32;

    console.log(Math.round(degreesFahrenheit * 100)/100);

}

/*Uncomment to test:
convertCelToFahr(["25"]);
convertCelToFahr(["0"]);
convertCelToFahr(["-5.5"]);
convertCelToFahr(["32.3"]);
    */