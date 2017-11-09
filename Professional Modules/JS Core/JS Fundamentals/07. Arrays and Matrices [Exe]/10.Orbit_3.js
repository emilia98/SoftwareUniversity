function printOrbitAroundAStar(array){
    let [width, height, x, y] = [array[0], array[1], array[2], array[3]];
    let matrix = [];

    for(let row = 0; row < height; row++){
        matrix.push(new Array(width));
    }

    matrix[x][y] = 1;

    for(let row = 0; row < height; row++){
        for(let col = 0; col < width; col++){
            matrix[row][col] = Math.max(Math.abs(x - row),
                                        Math.abs(y - col)) + 1;
        }
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