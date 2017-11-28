function appendLists(str){
    let splitString = str.split('|');
    let result = [];

    for(let index = splitString.length - 1; index >= 0; index--){
        let currentString = splitString[index].split(' ');

        for(let token of currentString){
            if(token != ""){
                result.push(token);
            }
        }
    }

    console.log(result.join(" "));
}

appendLists("1 2 3 |4 5 6 |  7  8");
appendLists("7 | 4  5|1 0| 2 5 |3");
appendLists("1| 4 5 6 7  |  8 9");