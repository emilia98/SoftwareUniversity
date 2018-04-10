function killBunnies(arr){
    arr = arr.filter(el => el !== "");
    // TRIM() ???
    let bombsCoordinates = arr.pop().split(" ").map(el => el.split(","));

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
            modifyMatrix(r, c, matrix[r][c])
        }
    }

    for(let row = 0; row < rows; row++){
        for(let col = 0; col < matrix[row].length; col++){
            if(matrix[row][col] > 0){
                damage += matrix[row][col];
                killedBunnies++;
            }
        }
    }

    console.log(damage);
    console.log(killedBunnies);

    function modifyMatrix(row, col, bombDamage){
        let cols = matrix[row].length;

        if(row >= 1){
            if(col >= 1){
                matrix[row - 1][col - 1] -= bombDamage;
            }

            if(col + 1 < cols){
                matrix[row - 1][col + 1] -= bombDamage;
            }

            matrix[row - 1][col] -= bombDamage;
        }

        if(row < rows - 1){
            if(col >= 1){
                matrix[row + 1][col - 1] -= bombDamage;
            }

            if(col + 1 < cols){
                matrix[row + 1][col + 1] -= bombDamage;
            }

            matrix[row + 1][col] -= bombDamage;
        }

        if(col >= 1){
            matrix[row][col - 1] -= bombDamage;
        }

        if(col + 1 < cols){
            matrix[row][col + 1] -= bombDamage;
        }

        matrix[row][col] -= bombDamage;
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