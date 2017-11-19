function addOrRemoveElements(str){
    let commands = str;
    let list = [];

    for (let command of commands) {
        let splitCommand = command.split(' ');
        let action = splitCommand[0];

        if(action == "add"){
            let number = Number(splitCommand[1]);
            list.push(number);

        } else if(action == "remove"){
            let index = parseInt(splitCommand[1]);
            list.splice(index, 1);
        }
    }

    list.forEach(el => console.log(el));
}

/* Uncomment to test:
addOrRemoveElements(["add 3", "add 5", "add 7"]);
addOrRemoveElements(["add 3", "add 5","remove 1","add 2"]);
addOrRemoveElements(["add 3", "add 5", "remove 2", "remove 0", "add 7"]);
*/





