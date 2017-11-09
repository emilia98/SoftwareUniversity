function attackDiagonals(array) {
    let matrix = [[]];

    for(let index in array){
        matrix[index] = array[index].split(' ').map(el => Number(el));
    }

    let diagonal1 = 0;
    let diagonal2 = 0;

    for(let row = 0; row < matrix.length; row++){
        for(let col = 0; col < matrix[row].length; col++){

            if(row == col){
                diagonal1 += matrix[row][col];
            }

            if(row + col == matrix.length - 1){
                diagonal2 += matrix[row][col];
            }
        }
    }

    if(diagonal1 == diagonal2){
        for(let row = 0; row < matrix.length; row++){
            for(let col = 0; col < matrix[row].length; col++){
                if(!(row == col || row + col == matrix.length - 1)){
                    matrix[row][col] = diagonal1;
                }
            }
        }
    }

    matrix.forEach(row => console.log(row.join(" ")));
}

/* Uncomment to test:
attackDiagonals(['5 3 12 3 1',
                 '11 4 23 2 5',
                 '101 12 3 21 10',
                 '1 4 5 2 2',
                 '5 22 33 11 1']);
attackDiagonals(['1 1 1',
                 '1 1 1',
                 '1 1 0']);
*/