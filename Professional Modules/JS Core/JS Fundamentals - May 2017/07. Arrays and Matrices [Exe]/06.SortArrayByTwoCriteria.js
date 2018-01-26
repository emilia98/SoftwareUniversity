function sortByTwoCriteria(array){
    let sortedArray = array.sort( (str1, str2) => str1.length >= str2.length).
    sort( function(str1, str2){

        if(str1.length == str2.length){
            return str1 >= str2;
        }}
    );
    sortedArray.forEach(el => console.log(el));
}

/* Uncomment to test:
sortByTwoCriteria(["alpha", "beta", "gamma",]);
sortByTwoCriteria(["Isacc", "Theodor", "Jack", "Harrison", "George"]);
sortByTwoCriteria(["test", "Deny", "omen", "Default"]);
*/