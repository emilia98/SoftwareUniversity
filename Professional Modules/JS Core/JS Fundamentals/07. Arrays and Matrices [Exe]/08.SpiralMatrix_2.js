function printSpiralMatrice(a, b) {
    let matrix = [];

    for (let indA = 0; indA < a; indA++) {
        matrix.push(new Array(b));
    }

    let startRow = 0;
    let endRow = a - 1;
    let startCol = 0;
    let endCol = b - 1;
    let currentNumber = 1;
    let numbersToPrint = a * b;

    while(currentNumber <= numbersToPrint){
        //TOP ROW
        for(let index = startCol; index <= endCol; index++){
            matrix[startRow][index] = currentNumber;
            currentNumber++;
        }

        if(currentNumber >= numbersToPrint){
            break;
        }

        //LEFT COLUMN
        for(let index = startRow + 1; index <= endRow - 1; index++){
            matrix[index][endCol] = currentNumber;
            currentNumber++;
        }
        if(currentNumber >= numbersToPrint){
            break;
        }

        //BOTTOM ROW
        for(let index = endCol; index >= startCol; index--){
            matrix[endRow][index] = currentNumber;
            currentNumber++;
        }

        if(currentNumber >= numbersToPrint){
            break;
        }
        //RIGHT COLUMN
        for(let index = endRow - 1; index >= startRow + 1; index--){
            matrix[index][startCol] = currentNumber;
            currentNumber++;
        }

        startRow++;
        endRow--;
        startCol++;
        endCol--;
    }

    matrix.forEach(row => console.log(row.join(" ")));
    //console.log();
}

/* Uncomment to test:
printSpiralMatrice(3, 3);
printSpiralMatrice(5, 5);
printSpiralMatrice(3, 4);
printSpiralMatrice(6, 7);
printSpiralMatrice(8, 8);
*/
