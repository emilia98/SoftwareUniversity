function printKeyValuePair(str){
    let pairs = str.slice(0, str.length - 1);
    let keyToFind = str[str.length - 1];
    let keyValuePairs = {};

    for (let pair of pairs) {
        let currentPair = pair.split(' ');
        let key = currentPair[0];
        let value = currentPair[1];

        keyValuePairs[key] = value;
    }

    if(keyValuePairs[keyToFind] == undefined){
        console.log("None");
    }else{
        console.log(keyValuePairs[keyToFind]);
    }

}

/* Uncomment to test:
printKeyValuePair(["key value", "key eulav", "test tset", "key"]);
printKeyValuePair(["3 test", "3 test1", "4 test2", "4 test3", "4 test5", "4"]);
printKeyValuePair(["3 bla", "3 alb", "2"]);
*/
