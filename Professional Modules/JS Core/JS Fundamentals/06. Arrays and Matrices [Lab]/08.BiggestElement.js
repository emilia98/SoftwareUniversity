function findBiggestElement(matrix){
    let max = Number.NEGATIVE_INFINITY;
    for(let rows = 0; rows < matrix.length; rows++){
        for(let cols = 0; cols < matrix[rows].length; cols++){
            let currentElement = matrix[rows][cols];

            if(currentElement > max){
                max = currentElement;
            }
        }
    }
    console.log(max);
}

/* Uncomment to test:
findBiggestElement([[20, 50, 10], [8, 33, 145]]);
findBiggestElement([[3, 5, 7, 12], [-1, 4, 33, 2], [8, 3, 0, 4]]);
*/