function findLargestThree(array){
    array.sort((a, b) => b - a);

    for (var index = 0; index < Math.min(3, array.length); index++) {
        console.log(array[index]);
    }
}

/* Uncomment to test:
findLargestThree([10, 30, 15, 20, 50, 5]);
findLargestThree([20, 30]);
findLargestThree([10, 5, 20, 3, 20]);
*/

