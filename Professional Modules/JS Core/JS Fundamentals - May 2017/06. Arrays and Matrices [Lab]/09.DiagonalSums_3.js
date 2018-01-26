function findDiagonalsSum(matrix){
    let n = matrix.length;
    let diagonal1 = [];
    let diagonal2 = [];

    matrix.forEach((num, row) => diagonal1.push(matrix[row][row]));
    matrix.forEach((num, row) => diagonal2.push(matrix[row][n - row - 1]));

    let sum1 = diagonal1.reduce( (a, b) => a + b);
    let sum2 = diagonal2.reduce( (a, b) => a + b);
    console.log(`${sum1} ${sum2}`);
}

/* Uncomment to test:
findDiagonalsSum([[20, 40], [10, 60]]);
findDiagonalsSum([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);
*/