function storeObjects(array){
    let inputData = array.slice(0, array.length);
    let finalObject = {Name: [], Age: [], Grade: []};
    let peopleCount = inputData.length;

    for(let input of inputData){
        let splitInput = input.split(" -> ");
        let name = splitInput[0];
        let age = parseInt(splitInput[1]);
        let grade = Number(splitInput[2]);

        finalObject["Name"].push(name);
        finalObject["Age"].push(age);
        finalObject["Grade"].push(grade.toFixed(2));
    }

    for(let index = 0; index < peopleCount; index++){
        for(let key in finalObject){
            console.log(`${key}: ${finalObject[key][index]}`);
        }
    }
}

/* Uncomment to test:
storeObjects(["Pesho -> 13 -> 6.00", "Ivan -> 12 -> 5.57", "Toni -> 13 -> 4.90"]);
*/



