function manipulateArray(str, cmds){
    let words = str.split(' ');
    let commands = cmds;

    for (let command of commands) {
        if(command == "Reverse"){
            words.reverse();
        }
        else if(command == "Distinct"){
            words = words.filter( (el, index, arr) => arr.indexOf(el) == index);
        }
        else{
            let splitCommand = command.split(' ');
            let index = parseInt(splitCommand[1]);
            let strToReplace = splitCommand[2];

            words[index] = strToReplace;
        }
    }

    console.log(words.join(", "));
}

manipulateArray("one one one two three four five",
    ["Distinct", "Reverse", "Replace 2 Hello"]);
manipulateArray("Alpha Bravo Charlie Delta Echo Foxtrot",
    ["Distinct", "Reverse", "Replace 1 Charlie",
        "Distinct", "Reverse", "Replace 2 Charlie" ]);
