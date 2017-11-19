function stringifyObject(array){
    let pairs = array.slice(0, array.length);
    let object = {};

    for(let pair of pairs){
        let splitPair = pair.split(" -> ");
        let key = splitPair[0];
        let value = splitPair[1];

        if(key == "grade" || key == "age"){
            object[key] = Number(value);
        }else{
            object[key] = value;
        }
    }

    console.log(JSON.stringify(object));
}

/* Uncomment to test:
stringifyObject(["name -> Angel", "surname -> Georgiev", "age -> 20", "grade -> 6.00", "date -> 23/05/1995", "town -> Sofia"]);
*/







