function printOrbitAroundAStar(array){
    let width = array[0];
    let height = array[1];
    let x = array[2];
    let y = array[3];

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
        if(leftCol < 0){
            leftCol = 0;
        }

        if(rightCol >= width){
            rightCol = width - 1;
        }

        if(topRow < 0){
            topRow = 0;
        }

        if(bottomRow >= height){
            bottomRow = height - 1;
        }

        // LEFT COLUMN
        for(let index = topRow; index <= bottomRow; index++){
            if(matrix[index][leftCol] == undefined){
                matrix[index][leftCol] = currentNumber;
                numbersAdded++;
            }
        }

        //RIGHT COL
        for(let index = topRow; index <= bottomRow; index++){
            if(matrix[index][rightCol] == undefined){
                matrix[index][rightCol] = currentNumber;
                numbersAdded++;
            }
        }

        // TOP ROW
        for(let index = leftCol + 1; index < rightCol; index++){
            if(matrix[topRow][index] == undefined){
                matrix[topRow][index] = currentNumber;
                numbersAdded++;
            }
        }

        // BOTTOM ROW
        for(let index = leftCol + 1; index < rightCol; index++){
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
printOrbitAroundAStar([6, 6, 2, 2]);
printOrbitAroundAStar([2, 2, 0, 0]);
*/