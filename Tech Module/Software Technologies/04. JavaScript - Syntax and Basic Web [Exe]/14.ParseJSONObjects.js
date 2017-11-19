function parseObjects(array){
    let objects = array;

    let parsedObjects = objects.map(object => JSON.parse(object));

    for (let object of parsedObjects) {
        for(let key in object){
            let property = key[0].toUpperCase() + key.slice(1, key.length);
            let value = object[key];

            console.log(`${property}: ${value}`);
        }
    }
}

/* Uncomment to test:
parseObjects(['{"name":"Gosho","age":10,"date":"19/06/2005"}', '{"name":"Tosho","age":11,"date":"04/04/2005"}']);
*/