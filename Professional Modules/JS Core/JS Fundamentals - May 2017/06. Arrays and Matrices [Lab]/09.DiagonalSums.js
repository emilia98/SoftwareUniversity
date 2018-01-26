function findDiagonalsSum(matrix){
    let n = matrix.length;

    let diagonal1 = [];
    let diagonal2 = [];
    for(let row = 0; row < n; row++){
        for(let col = 0; col < n; col++){
            if(col == row){
                diagonal1.push(matrix[row][col]);
            }

            if(row + col == (n - 1)){
                diagonal2.push(matrix[row][col]);
            }
        }
    }
    let sum1 = diagonal1.reduce( (a, b) => a + b);
    let sum2 = diagonal2.reduce( (a, b) => a + b);
    console.log(`${sum1} ${sum2}`);
}

/* Uncomment to test:
findDiagonalsSum([[20, 40], [10, 60]]);
findDiagonalsSum([[3, 5, 17], [-1, 7, 14], [1, -8, 89]]);
*/