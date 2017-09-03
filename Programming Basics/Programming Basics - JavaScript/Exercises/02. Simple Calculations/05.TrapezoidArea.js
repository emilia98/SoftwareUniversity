function calculateTrapezoidArea([arg1, arg2, arg3]){
    let a = parseFloat(arg1),
        b = parseFloat(arg2),
        h = parseFloat(arg3);
    let area = (a + b) * h / 2;

    console.log("Trapezoid area = " + area);
}

/* Uncomment to test
calculateTrapezoidArea(["3","9","12"]);
calculateTrapezoidArea(["8","13","7"]);
*/