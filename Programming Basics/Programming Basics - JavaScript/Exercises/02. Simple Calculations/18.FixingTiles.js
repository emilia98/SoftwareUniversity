function calculateTilesAndTimeNeeded([arg1, arg2, arg3, arg4, arg5]){
    let groundWidth = parseInt(arg1);
    let tileWidth = parseFloat(arg2);
    let tileLength = parseFloat(arg3);
    let benchWidth = parseInt(arg4);
    let benchLength = parseInt(arg5);

    let groundArea = groundWidth * groundWidth;
    let benchArea = benchWidth * benchLength;
    let tiledGroundArea = groundArea - benchArea; // area to be covered with tiles
    let tileArea = tileWidth * tileLength;

    let tilesNeeded = tiledGroundArea / tileArea;
    let timeNeeded = tilesNeeded * 0.2;

    console.log(tilesNeeded.toFixed(2));
    console.log(timeNeeded.toFixed(2));
}

/* Uncomment to test:
calculateTilesAndTimeNeeded(["20", "5", "4", "1", "2"]);
calculateTilesAndTimeNeeded(["40", "0.8", "0.6", "3", "5"]);
    */