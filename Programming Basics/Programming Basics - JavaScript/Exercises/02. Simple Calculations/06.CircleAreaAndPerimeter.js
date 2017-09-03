function calculateCircle([arg1]){
    let rad = parseFloat(arg1);
    let area = Math.PI * rad * rad;
    let perimeter = 2 * Math.PI * rad;

    console.log("Area = " + area);
    console.log("Perimeter = " + perimeter);
}

/* Uncomment to test:
calculateCircle(["3"]);
calculateCircle(["10"]);
    */