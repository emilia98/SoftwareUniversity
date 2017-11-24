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
            words = words.reverse();
        }
        else if(command == "Distinct"){
            words = words.filter( (el ,ind, arr) => arr.indexOf(el) == ind);
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
}

manipulateArray("one one one two three four five",
                ["Distinct", "Reverse", "Replace 7 Hello", "Replace -2 Hello",                     "Replace 0 Hello","END"]);
manipulateArray("Alpha Bravo Charlie Delta Echo Foxtrot",
                ["Distinct", "Reverse", "Replace 0 Charlie",
                 "Reverse", "Replace 1 Charlie", "Distinct",
                 "Replace 4 Charlie",  "END" ]);


