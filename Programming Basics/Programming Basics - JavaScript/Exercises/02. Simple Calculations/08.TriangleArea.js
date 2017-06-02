function calculateTriangleArea([arg1,arg2]){
    let a = parseFloat(arg1);
    let h = parseFloat(arg2);
    let area = a * h / 2;

    console.log("Triangle area = " + area.toFixed(2));
}

calculateTriangleArea(["20","30"]);
calculateTriangleArea(["15","35"]);
calculateTriangleArea(["7.75","8.45"]);
calculateTriangleArea(["1.23456","4.56789"]);

