function addOrRemoveElements(str){
    let commands = str;
    let array = new Array(commands.length);
    let counter = 0;

    for (let command of commands) {
        let splitCommand = command.split(' ');
        let action = splitCommand[0];

        if(action == "add"){
            let number = Number(splitCommand[1]);
            array[counter] = number;
            counter++;

        } else if(action == "remove"){
            let index = parseInt(splitCommand[1]);

            if(index >= 0 && index < counter){
                array = removeElement(array, index, counter);
                counter--;
            }
        }
    }

    for(let element of array){
        if(element != undefined){
            console.log(element);
        }
    }

    function removeElement(array, indexToRemove, elementsAdded) {
        let modifiedArray = new Array(elementsAdded - 1);
        let cnt = 0;

        for(let index = 0; index < elementsAdded; index++){
            if(index != indexToRemove){
                modifiedArray[cnt] = array[index];
                cnt++;
            }
        }
        return modifiedArray;
    }
}

/* Uncomment to test:
addOrRemoveElements(["add 3", "add 5", "add 7"]);
addOrRemoveElements(["add 3", "add 5","remove 1","add 2"]);
addOrRemoveElements(["add 3", "add 5", "remove 2", "remove 0", "add 7", "remove 2"]);
addOrRemoveElements(["remove 2", "remove 3","remove 0"]);
*/







