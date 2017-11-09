function addAndRemoveElements(array){
    let numbersArray = [];
    let currentNumber = 1;

    for(let command of array){
        if(command == "add"){
            numbersArray.push(currentNumber);
        }
        else if(command == "remove"){
            numbersArray.pop();
        }
        currentNumber++;
    }

    if(numbersArray.length == 0){
        console.log("Empty");
    }
    else{
        numbersArray.forEach(el => console.log(el));
    }
}

/* Uncomment to test:
addAndRemoveElements(["add", "add", "add", "add"]);
addAndRemoveElements(["add", "add", "remove" , "add", "add"]);
addAndRemoveElements(["remove", "remove", "remove"]);
*/



