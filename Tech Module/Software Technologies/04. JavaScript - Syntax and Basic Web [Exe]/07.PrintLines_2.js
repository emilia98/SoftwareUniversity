function printLines(str) {
    let commands = str;

    let indexOfEndingCommand = commands.indexOf("Stop");
    commands.slice(0, indexOfEndingCommand).forEach(el => console.log(el));
}

/* Uncomment to test:
printLines(["Line 1", "Line 2", "Line 3", "Stop"]);
printLines(["3", "6", "5", "4", "Stop", "10", "12"]);
*/
