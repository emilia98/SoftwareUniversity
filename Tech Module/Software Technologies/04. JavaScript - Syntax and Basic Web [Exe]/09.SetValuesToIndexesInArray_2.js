function setValuesToIndexes(str){
    let newArraySize = parseInt(str[0]);
    let commands = str.slice(1, str.length);

    let newArray = new Array(newArraySize);
    newArray.fill(0);

    commands.forEach(el => el.split(" - ").reduce((ind, val) => newArray[ind] = val));

   newArray.forEach(el => console.log(el));
}

/* Uncomment to test:
setValuesToIndexes(["3", "0 - 5", "1 - 6", "2 - 7"]);
setValuesToIndexes(["2", "0 - 5", "0 - 6", "0 - 7"]);
setValuesToIndexes(["5", "0 - 3", "3 - -1", "4 - 2"]);
*/

