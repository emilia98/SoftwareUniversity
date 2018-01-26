function sortByTwoCriteria(array) {
    array.sort((str1, str2) => str1.length >= str2.length)
         .sort((str1, str2) => (str1.length == str2.length && str1 >= str2))
         .forEach(el => console.log(el));
}

/* Uncomment to test:
sortByTwoCriteria(["alpha", "beta", "gamma",]);
sortByTwoCriteria(["Isacc", "Theodor", "Jack", "Harrison", "George"]);
sortByTwoCriteria(["test", "Deny", "omen", "Default"]);
*/