function manipulateArray(str, cmds){
    let words = str.split(' ');
    let commands = cmds;
    let splitCommand = commands[0].split(' ');
    let command = splitCommand[0];
    let index = 1;

    while(true){
        if(command == "END"){
            break;
        }

        if(command == "Reverse"){
            words = reverseArray(words);
        }
        else if(command == "Distinct"){
            words = distinctArray(words);
        }
        else if(command == "Replace"){
            let indexToRemove = parseInt(splitCommand[1]);
            let strToRemove = splitCommand[2];

            if(indexToRemove >= 0 && indexToRemove < words.length){
                words[indexToRemove] = strToRemove;
            }
            else{
                console.log("Invalid input!");
            }
        }
        else{
            console.log("Invalid input!");
        }

        splitCommand = commands[index].split(' ');
        command = splitCommand[0];
        index++;
    }

    console.log(words.join(", "));

    function reverseArray(array){
        let size = array.length;
        let reversedArray = new Array(size);

        for(let index = 0; index < size; index++){
            reversedArray[index] = array[size - 1 - index];
        }
        return reversedArray;
    }

    function distinctArray(array){
        let size = array.length;
        let cnt = 0;
        let indexesToRemove = new Array(size);

        for(let index = 0; index < size - 1; index++){
            let currentElement = array[index];

            for(let innerIndex = index + 1; innerIndex < size; innerIndex++){
                if(currentElement == array[innerIndex] &&
                    indexesToRemove.indexOf(innerIndex) == -1){
                    indexesToRemove[cnt] = innerIndex;
                    cnt++;
                }
            }
        }

        let distinctedArray = new Array(size);
        cnt = 0;
        for(let index = 0; index < size; index++){
            if(indexesToRemove.indexOf(index) == -1){
                distinctedArray[cnt] = array[index];
                cnt++;
            }
        }
        distinctedArray = distinctedArray.slice(0, cnt);
        return distinctedArray;
    }
}

manipulateArray("one one one two three four five",
    ["Distinct", "Reverse", "Replace 7 Hello", "Replace -2 Hello",                     "Replace 0 Hello","END"]);
manipulateArray("Alpha Bravo Charlie Delta Echo Foxtrot",
    ["Distinct", "Reverse", "Replace 0 Charlie",
        "Reverse", "Replace 1 Charlie", "Distinct",
        "Replace 4 Charlie",  "END" ]);


