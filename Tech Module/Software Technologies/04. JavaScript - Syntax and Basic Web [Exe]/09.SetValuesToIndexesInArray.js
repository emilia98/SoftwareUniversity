function setValuesToIndexes(str){
    let newArraySize = parseInt(str[0]);
    let commands = str.slice(1, str.length);
    let newArray = new Array(newArraySize);

    for(let index = 0; index < newArraySize; index++){
        newArray[index] = 0;
    }

    for(let command of commands){
        let splitCommand = command.split(" - ");
        let index = parseInt(splitCommand[0]);
        let value = splitCommand[1];

        newArray[index] = value;
    }

    for (var element of newArray) {
        console.log(element);
    }
}

/* Uncomment to test:
setValuesToIndexes(["3", "0 - 5", "1 - 6", "2 - 7"]);
setValuesToIndexes(["2", "0 - 5", "0 - 6", "0 - 7"]);
setValuesToIndexes(["5", "0 - 3", "3 - -1", "4 - 2"]);
*/



