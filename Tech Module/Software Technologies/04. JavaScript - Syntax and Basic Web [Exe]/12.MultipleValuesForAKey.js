function printKeyValuePairs(array){
    let pairs = array.slice(0, array.length - 1);
    let keyToFind = array[array.length - 1];

    let keyValuePairs = {};

    for(let pair of pairs){
        let splitPair = pair.split(' ');
        let key = splitPair[0];
        let value = splitPair[1];

        if(!(key in keyValuePairs)){
            keyValuePairs[key] =[];
        }

        keyValuePairs[key].push(value);
    }

    if(keyValuePairs[keyToFind] == undefined){
        console.log("None");
    }else{
        keyValuePairs[keyToFind].forEach(value => console.log(value));
    }
}

/* Uncomment to test:
printKeyValuePairs(["key value", "key eulav", "test tset", "key"]);
printKeyValuePairs(["3 test", "3 test1", "4 test2", "4 test3", "4 test5", "4"]);
printKeyValuePairs(["3 bla", "3 alb", "2"]);
*/
