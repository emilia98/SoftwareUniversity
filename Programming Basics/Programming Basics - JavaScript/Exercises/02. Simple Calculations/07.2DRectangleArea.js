function calculateAreaAndPerimeterOfRectangle([arg1, arg2, arg3,arg4]){
    let x1 = parseFloat(arg1),
        y1 = parseFloat(arg2),
        x2 = parseFloat(arg3),
        y2 = parseFloat(arg4);

    let height = Math.abs(y1 - y2);
    let width = Math.abs(x1 - x2);

    let area = height * width;
    let perimeter = 2 * (height + width);

    console.log(area);
    console.log(perimeter);
}

//Test until Test System gives you 100/100, because sometimes return "Time Limit"
/*Uncomment to test:
calculateAreaAndPerimeterOfRectangle(["60", "20", "10", "50"]);
calculateAreaAndPerimeterOfRectangle(["30", "40", "70", "-10"]);
calculateAreaAndPerimeterOfRectangle(["600.25", "500.75", "100.50", "-200.5"]);
*/
