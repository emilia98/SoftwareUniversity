function calculateRadiansToDegrees([arg1]){
    let radians = parseFloat(arg1);
    let degrees = radians * (180 / Math.PI);

    console.log(Math.round(degrees));
}

/* Uncomment to test:
calculateRadiansToDegrees(["3.1416"]);
calculateRadiansToDegrees(["6.2832"]);
calculateRadiansToDegrees(["0.7854"]);
calculateRadiansToDegrees(["0.5236"]);
    */