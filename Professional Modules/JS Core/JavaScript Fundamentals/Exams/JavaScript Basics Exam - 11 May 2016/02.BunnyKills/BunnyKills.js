function killBunnies(arr){
    arr = arr.filter(el => el !== "");
    // TRIM() ??? -> NO
    let bombsCoordinates = arr.pop().split(" ").map(el => el.split(","));

    // Fill the matrix
    let matrix = [];
    arr.slice(0).forEach(row => {
        matrix.push(row.split(" ").map(el => Number(el)));
    });
    let rows = matrix.length;

    let damage = 0;
    let killedBunnies = 0;

    for(let bomb of bombsCoordinates){
        let [r, c] = bomb.map(el => parseInt(el));

        if(matrix[r][c] > 0){
            killedBunnies++;
            damage += matrix[r][c];
            modifyMatrix(r, c, matrix[r][c]);
        }
    }

    matrix.forEach(row => {
        row = row.filter(el => el > 0);
        killedBunnies += row.length;

        if(row.length > 0){
            damage += row.reduce((a, b) => a + b)
        }
    });

    console.log(damage);
    console.log(killedBunnies);

    function modifyMatrix(row, col, bombDamage){
        let cols = matrix[row].length;

        for(let currentRow = Math.max(row - 1, 0); currentRow <= Math.min(row + 1, rows - 1); currentRow++){
            for(let currentCol = Math.max(col - 1, 0); currentCol <= Math.min(col + 1, cols - 1); currentCol++){

                if(matrix[currentRow][currentCol] <= 0){
                    continue;
                }
                matrix[currentRow][currentCol] -= bombDamage;
            }
        }
    }
}

/* Uncomment to test:
killBunnies([
    "10 10 10",
    "10 10 10",
    "10 10 10",
    "0,0",
    ""
]);


killBunnies([
    "5 10 15 20",
    "10 10 10 10",
    "10 15 10 10",
    "10 10 10 10",
    "2,2 0,1",
    ""
]);
*/