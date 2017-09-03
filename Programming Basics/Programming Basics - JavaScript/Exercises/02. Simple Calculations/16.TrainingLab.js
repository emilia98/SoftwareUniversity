function calculateTrainingLabWorkplaces([arg1, arg2]){
    let widthInMeters = parseFloat(arg1);
    let heightInMeters = parseFloat(arg2);

    let width = widthInMeters * 100;
    let height = heightInMeters * 100;
    height -= 100; // for the corridor

    let rows = Math.floor(width / 120);
    let desksPerRow = Math.floor(height / 70);

    let workplaces = rows * desksPerRow;
    workplaces -= 3; //for the 2 + 1 lost workplaces
    console.log(workplaces);
}

/* Uncomment to test:
calculateTrainingLabWorkplaces(["15", "8.9"]);
calculateTrainingLabWorkplaces(["8.4", "5.2"]);
    */