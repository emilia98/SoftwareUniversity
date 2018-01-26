function printOrbitAroundAStar(array){
    let [width, height, x, y] = [array[0], array[1], array[2], array[3]];
    let matrix = [];

    for(let row = 0; row < height; row++){
        matrix.push(new Array(width));
    }

    matrix[x][y] = 1;

    let numbersAdded = 1;
    let allNumbers = width * height;
    let currentNumber = 2;

    // Coordinates of first orbit
    let leftCol = y - 1;
    let rightCol = y + 1;
    let topRow = x - 1;
    let bottomRow = x + 1;

    while(numbersAdded < allNumbers){
        leftCol = leftCol < 0 ? leftCol = 0 : leftCol;
        rightCol = rightCol >= width ? width - 1 : rightCol;
        topRow = topRow < 0 ? topRow = 0 : topRow;
        bottomRow = bottomRow >= height ?  bottomRow = height - 1 : bottomRow;

        for(let index = topRow; index <= bottomRow; index++){
            // LEFT COLUMN
            if(matrix[index][leftCol] == undefined){
                matrix[index][leftCol] = currentNumber;
                numbersAdded++;
            }

            //RIGHT COL
            if(matrix[index][rightCol] == undefined){
                matrix[index][rightCol] = currentNumber;
                numbersAdded++;
            }
        }

        for(let index = leftCol + 1; index < rightCol; index++){
            // TOP ROW
            if(matrix[topRow][index] == undefined){
                matrix[topRow][index] = currentNumber;
                numbersAdded++;
            }

            // BOTTOM ROW
            if(matrix[bottomRow][index] == undefined){
                matrix[bottomRow][index] = currentNumber;
                numbersAdded++;
            }
        }
        currentNumber++;

        topRow--;
        rightCol++;
        bottomRow++;
        leftCol--;
    }
    matrix.forEach(row => console.log(row.join(" ")));
}

/* Uncomment to test:
printOrbitAroundAStar([5, 5, 2, 3]);
printOrbitAroundAStar([4, 4, 1, 2]);
printOrbitAroundAStar([4, 4, 0, 0]);
printOrbitAroundAStar([5, 5, 2, 2]);
printOrbitAroundAStar([6, 6, 2, 2]);
printOrbitAroundAStar([2, 2, 0, 0]);
printOrbitAroundAStar([3, 3, 2, 2]);
*/