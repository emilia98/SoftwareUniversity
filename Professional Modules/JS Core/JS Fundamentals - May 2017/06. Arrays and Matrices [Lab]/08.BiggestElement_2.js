function findBiggestElement(matrix){
    let max = Number.NEGATIVE_INFINITY;
    matrix.forEach(row => row.forEach(
                   num => max = Math.max(max, num)));
    console.log(max);
}

/* Uncomment to test:
findBiggestElement([[20, 50, 10], [8, 33, 145]]);
findBiggestElement([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);
*/
