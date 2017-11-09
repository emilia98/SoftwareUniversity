function printElements(array){
    let size = array.length;
    let n = parseInt(array[size - 1]);

    for(let index = 0; index < size - 1; index++){
        if(index % n == 0){
            console.log(array[index]);
        }
    }
}

/* Uncomment to test:
printElements([ "5", "20", "31", "4", "20", "2"]);
printElements([ "dsa", "asd", "test", "tset", "2"]);
printElements([ "1", "2", "3", "4", "5", "6"]);
*/