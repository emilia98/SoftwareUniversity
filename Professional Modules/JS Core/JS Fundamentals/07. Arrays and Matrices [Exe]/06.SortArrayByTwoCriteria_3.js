function sortByTwoCriteria(array) {
    array = sortByLength(array);
    array = sortAlphabetically(array);
    array.forEach(el => console.log(el));

    function sortByLength(array){
        let isSorted = false;

        while(!isSorted){
            isSorted = true;
            for(let index = 0; index < array.length - 1; index++) {
                let str1 = array[index];
                let str2 = array[index + 1];

                if (str1.length > str2.length) {
                    let temp = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = temp;
                    isSorted = false;
                }
            }
        }
        return array;
    }

    function sortAlphabetically(array){
        let isSorted = false;

        while(!isSorted){
            isSorted = true;
            for(let index = 0; index < array.length - 1; index++) {
                let str1 = array[index];
                let str2 = array[index + 1];

                if ((str1.length == str2.length) &&
                    (str1.toUpperCase() > str2.toUpperCase())) {
                    let temp = array[index];
                    array[index] = array[index + 1];
                    array[index + 1] = temp;
                    isSorted = false;
                }
            }
        }
        return array;
    }
}

/* Uncomment to test:
sortByTwoCriteria(["alpha", "beta", "gamma",]);
sortByTwoCriteria(["Isacc", "Theodor", "Jack", "Harrison", "George"]);
sortByTwoCriteria(["test", "Deny", "omen", "Default"]);
sortByTwoCriteria(["test", "Pesho", "PeshO", "PeshoV","Peshov"]);
sortByTwoCriteria(["Bella", "Anni", "Dany", "Bela","dany"]);
*/
