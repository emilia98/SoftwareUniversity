function addAndRemoveElements(array){
    let numbersArray = [];

    for(let index = 0; index < array.length; index++){
        let command = array[index];
        let currentNumber = index + 1;

        if(command == "add"){
            numbersArray.push(currentNumber);
        }
        else if(command == "remove"){
            numbersArray.pop();
        }
    }

    if(numbersArray.length == 0){
        console.log("Empty");
    }
    else{
        for(let number of numbersArray){
            console.log(number);
        }
    }
}

/* Uncomment to test:
addAndRemoveElements(["add", "add", "add", "add"]);
addAndRemoveElements(["add", "add", "remove" , "add", "add"]);
addAndRemoveElements(["remove", "remove", "remove"]);
*/


