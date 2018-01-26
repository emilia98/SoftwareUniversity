function findDiagonalsSum(matrix){
    let n = matrix.length;
    let sumDiagonal1 = 0;
    let sumDiagonal2 = 0;

    for(let row = 0; row < n; row++){
        sumDiagonal1 += matrix[row][row];
        sumDiagonal2 += matrix[row][n - row - 1];
    }
    console.log(`${sumDiagonal1} ${sumDiagonal2}`);
}

/*Uncomment to test:
findDiagonalsSum([[20, 40], [10, 60]]);
findDiagonalsSum([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);
*/
