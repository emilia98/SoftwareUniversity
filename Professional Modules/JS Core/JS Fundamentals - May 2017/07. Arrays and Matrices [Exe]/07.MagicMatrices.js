function findIfMatriceIsMagic(matrix){
    let firstRowSum = matrix[0].reduce( (a, b) => a + b);

    console.log(isMatriceMagic(matrix, firstRowSum));

    function isMatriceMagic(matrix, magicSum){
        let colSums = [];
        let rows = matrix.length;
        for(let row = 0; row < rows; row++){
            let currentRowSum = matrix[row].reduce( (a, b) => a + b);

            if(currentRowSum != magicSum){
                return false;
            }

            for(let col = 0; col < matrix[row].length; col++){
                if(row == 0){

                    colSums.push(matrix[row][col]);
                }
                else{
                    colSums[col] += matrix[row][col];
                }
            }
        }

        for(let sum of colSums){
            if(sum != magicSum){
                return false;
            }
        }

        return true;
    }
}

/* Uncomment to test:
findIfMatriceIsMagic([[4, 5, 6], [6, 5, 4], [5, 5, 5]]);
findIfMatriceIsMagic([[11, 32, 45], [21, 0, 1], [21, 1, 1]]);
findIfMatriceIsMagic([[1, 0, 0], [0, 0, 1], [0, 1, 0]]);
*/