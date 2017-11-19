function printLines(str) {
    let commands = str;

    for (let command of commands) {
        if(command == "Stop"){
            break;
        }
        console.log(command);
    }
}

/* Uncomment to test:
printLines(["Line 1", "Line 2", "Line 3", "Stop"]);
printLines(["3", "6", "5", "4", "Stop", "10", "12"]);
*/