function convertInchToCm([arg1]){
    let inches = parseFloat(arg1);
    let centimeters = inches * 2.54;
    console.log("centimeters = " + centimeters);
}

/* Uncomment to test
convertInchToCm(["10"]);
convertInchToCm(["25"]);
convertInchToCm(["2.5"]);
    */