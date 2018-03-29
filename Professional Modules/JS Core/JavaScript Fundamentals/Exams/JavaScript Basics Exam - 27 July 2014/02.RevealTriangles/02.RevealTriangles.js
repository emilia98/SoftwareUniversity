function revealTriangles(arr){
    let coordinates = {};
    let symbolGrid = arr.map(line => line.split(""));

    for(let row = 0; row < arr.length - 1; row++){
        coordinates[row] = [];
        for(let index = 1; index <= symbolGrid[row].length - 1; index++){
            let symbol = symbolGrid[row][index];
            let lowerLeft = symbolGrid[row + 1][index - 1];
            let lowerMiddle = symbolGrid[row + 1][index];
            let lowerRight = symbolGrid[row + 1][index + 1];

            if(symbol === lowerLeft && symbol === lowerMiddle && symbol === lowerRight){
                coordinates[row].push(index);
            }
        }
    }

    for(let rowIndex in coordinates){
        let row = parseInt(rowIndex);
        if(coordinates[rowIndex].length !== 0){
            for(let col of coordinates[rowIndex]){
                symbolGrid[row][col] = '*';
                symbolGrid[row + 1][col - 1] = '*';
                symbolGrid[row + 1][col] = '*';
                symbolGrid[row + 1][col + 1] = '*';
            }
        }
    }
    console.log(symbolGrid.map(p => p.join("")).join("\n"));
}

/* Uncomment to test:
revealTriangles(["abcdexgh", "bbbdxxxh", "abcxxxxx"]);
console.log();
revealTriangles(["aa", "aaa", "aaaa", "aaaaa"]);
console.log();
revealTriangles(["ax", "xxx", "b", "bbb", "bbbb"]);
console.log();
revealTriangles(["dffdsgyefg", "ffffeyeee", "jbfffays", "dagfffdsss", "dfdfa", "dadaaadddf", "sdaaaaa", "daaaaaaasf"]);
*/