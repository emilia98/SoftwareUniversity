function createRadioCrystals(array){
    let targetThickness = Number(array[0]);

    for(let index = 1; index < array.length; index++){
        operateWithCrystal(array[index], targetThickness);
    }

    function cut(currentResult, targetThickness) {
        let count = 0;
        let hasCut = false;
        while(true){
            if(currentResult / 4 >= targetThickness){
                currentResult /= 4;
                count++;
                hasCut = true;
            }
            else{
                break;
            }
        }

        if(hasCut){
            console.log(`Cut x${count}`);
            currentResult = transport(currentResult);
        }
        return currentResult;
    }

    function lap(currentResult, targetThickness) {
        let count = 0;
        let hasLap = false;
        while(true){
            if(currentResult * 0.8 >= targetThickness){
                currentResult *= 0.8;
                count++;
                hasLap = true;
            }
            else{
                break;
            }
        }

        if(hasLap){
            console.log(`Lap x${count}`);
            currentResult = transport(currentResult);
        }
        return currentResult;
    }

    function grind(currentResult, targetThickness) {
        let count = 0;
        let hasGrind = false;
        while(true){
            if(currentResult - 20 >= targetThickness){
                currentResult -= 20;
                count++;
                hasGrind = true;
            }
            else{
                break;
            }
        }

        if(hasGrind){
            console.log(`Grind x${count}`);
            currentResult = transport(currentResult);
        }
        return currentResult;
    }

    function etch(currentResult, targetThickness) {
        let count = 0;
        let hasEtch = false;
        while(true){
            if(currentResult - 2 >= targetThickness - 1){
                currentResult -= 2;
                count++;
                hasEtch = true;
            }
            else{
                break;
            }
        }

        if(hasEtch){
            console.log(`Etch x${count}`);
            currentResult = transport(currentResult);
        }
        return currentResult;
    }

    function xRay(currentResult){
        console.log(`X-ray x1`);
        return currentResult + 1;
    }

    function transport(currentResult) {
        console.log("Transporting and washing");
        return parseInt(currentResult);
    }

    function operateWithCrystal(crystal, targetThickness){
        let currentResult = crystal;
        let operationIndex = 1;

        console.log(`Processing chunk ${crystal} microns`);
        while(currentResult != targetThickness){
            if(operationIndex == 1){
                currentResult = cut(currentResult, targetThickness);
            }
            else if(operationIndex == 2){
                currentResult = lap(currentResult, targetThickness);
            }
            else if(operationIndex == 3){
                currentResult = grind(currentResult, targetThickness);
            }
            else if(operationIndex == 4){
                currentResult = etch(currentResult, targetThickness);
            }
            else if(operationIndex == 5){
                currentResult = xRay(currentResult);
            }
            operationIndex++;
        }
        console.log(`Finished crystal ${targetThickness} microns`);
    }
}

/* Uncomment to test:
createRadioCrystals([1375, 50000]);
createRadioCrystals([1000, 4000, 8100]);
createRadioCrystals([1000, 999]);
*/

