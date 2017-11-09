function printElements(array){
    let size = array.length;
    let n = parseInt(array[size - 1]);

    array.slice(0, size - 1).
          filter( (el, i) => i % n == 0).
          forEach(el => console.log(el));
}

/* Uncomment to test:
printElements([ "5", "20", "31", "4", "20", "2"]);
printElements([ "dsa", "asd", "test", "tset", "2"]);
printElements([ "1", "2", "3", "4", "5", "6"]);
*/
