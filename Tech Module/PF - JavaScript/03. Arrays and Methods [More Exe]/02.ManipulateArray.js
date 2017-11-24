function manipulateArray(str, cmds){
    let words = str.split(' ');
    let commands = cmds;

    for (let command of commands) {
        if(command == "Reverse"){
            words = reverseArray(words);
        }
        else if(command == "Distinct"){
            words = distinctElements(words);
        }
        else{
            let splitCommand = command.split(' ');
            let index = parseInt(splitCommand[1]);
            let strToReplace = splitCommand[2];

            words[index] = strToReplace;
        }
    }

    console.log(words.join(", "));

    function reverseArray(array){
        let size = array.length;
        let reversedArray = new Array(size);

        for (var index = size - 1; index >= 0; index--) {
            reversedArray[size - 1 - index] = array[index];
        }
        return reversedArray;
    }

    function distinctElements(array) {
        let size = array.length;
        let indexesToUse = new Array(size);
        let cnt = 0;

        for (let outerIndex = 0; outerIndex < size - 1; outerIndex++){
            for(let innerIndex = outerIndex + 1; innerIndex < size; innerIndex++){
                if(array[innerIndex] == array[outerIndex]){
                    if(indexesToUse.indexOf(innerIndex) == -1){
                        indexesToUse[cnt] = innerIndex;
                        cnt++;
                    }
                }
            }
        }
        indexesToUse = indexesToUse.slice(0, cnt);

        let distinctedArray = new Array(size);
        let countAddedElements = 0;
        for(let index = 0; index < size; index++){
            if(!indexesToUse.includes(index)){
                distinctedArray[countAddedElements] = array[index];
                countAddedElements++;
            }
        }
        distinctedArray = distinctedArray.slice(0, countAddedElements);
        return distinctedArray;
    }
}

manipulateArray("one one one two three four five",
    ["Distinct", "Reverse", "Replace 2 Hello"]);
manipulateArray("Alpha Bravo Charlie Delta Echo Foxtrot",
    ["Distinct", "Reverse", "Replace 1 Charlie",
        "Distinct", "Reverse", "Replace 2 Charlie" ]);
