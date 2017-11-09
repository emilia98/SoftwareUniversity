function attackDiagonals(array) {
    let matrix = [[]];

    for(let index in array){
        matrix[index] = array[index].split(' ').map(el => Number(el));
    }

    let diagonal1 = 0;
    let diagonal2 = 0;
    //Sum of diagonal1
    matrix.forEach( (array, row) => matrix[row].filter((num, col) =>
        row == col).forEach( el => diagonal1 += el ));
    //Sum of diagonal2
    matrix.forEach( (array, row) => matrix[row].filter((num, col) =>
        (row + col) == matrix[row].length - 1).
    forEach( el => diagonal2 += el ));


    if(diagonal1 == diagonal2){
        matrix.forEach( (array, row) =>
            array.forEach( function(num, col){
                if(!(row == col || (row + col) == matrix[row].length - 1)){
                    matrix[row][col] = diagonal1;
                }
            } ) );
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