function storeObjects(array){
    let inputData = array.slice(0, array.length);
    let finalObjects = [];

    for(let input of inputData){
        let splitInput = input.split(" -> ");
        let name = splitInput[0];
        let age = parseInt(splitInput[1]);
        let grade = Number(splitInput[2]);

        let currentObject = {};
        currentObject["Name"] = name;
        currentObject["Age"] = age;
        currentObject["Grade"] = grade.toFixed(2);

        finalObjects.push(currentObject);
    }

    for(let object of finalObjects){
        for(let key in object){
            console.log(`${key}: ${object[key]}`);
        }
    }
}

/* Uncomment to test:
storeObjects(["Pesho -> 13 -> 6.00", "Ivan -> 12 -> 5.57", "Toni -> 13 -> 4.90"]);
*/