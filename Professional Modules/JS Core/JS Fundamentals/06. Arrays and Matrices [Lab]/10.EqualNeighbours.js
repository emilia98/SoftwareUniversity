function findEqualNeighbours(matrix){
    let rows = matrix.length;
    let pairs = 0;

    for(let row = 0; row < rows; row++){
        let cols = matrix[row].length;

        for(let col = 0; col < cols; col++){
            let currentElement = matrix[row][col];

            if(col + 1 < cols){
                let horizontalNeighbour = matrix[row][col + 1];
                if(currentElement === horizontalNeighbour){
                    pairs++;
                }
            }
            if(row + 1 < rows){
                let verticalNeighbour = matrix[row + 1][col];
                if(currentElement === verticalNeighbour){
                    pairs++;
                }
            }
        }
    }
    console.log(pairs);
}

/* Uncomment to test:
findEqualNeighbours([['2', '3', '4', '7', '0'],
                     ['4', '0', '5', '3', '4'],
                     ['2', '3', '5', '4', '2'],
                     ['9', '8', '7', '5', '4']]);
findEqualNeighbours([['test', 'yes', 'yo', 'ho'],
                     ['well', 'done', 'yo', '6'],
                     ['not', 'done', 'yet', '5']]);

findEqualNeighbours([['2', '3', '4', '7', '0'],
                     ['4', '0', '5', '3', '4'],
                     ['2', '3', '5', '4', '4'],
                     ['9', '8', '7', '5', '4']]);
*/