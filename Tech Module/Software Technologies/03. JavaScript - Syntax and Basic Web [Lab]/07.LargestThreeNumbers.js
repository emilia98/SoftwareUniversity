function findLargestThree(array){
    array.sort((a, b) => b - a).slice(0, 3).forEach(el => console.log(el));
}

/* Uncomment to test:
findLargestThree([10, 30, 15, 20, 50, 5]);
findLargestThree([20, 30]);
findLargestThree([10, 5, 20, 3, 20]);
*/
