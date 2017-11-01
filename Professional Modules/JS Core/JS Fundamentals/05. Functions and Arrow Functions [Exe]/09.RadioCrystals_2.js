function createRadioCrystals(array){
    let targetThickness = Number(array[0]);

    for(let index = 1; index < array.length; index++){
        operateWithCrystal(array[index], targetThickness);
    }

    function doOperation(currentResult, targetThickness, operation) {
        let count = 0;
        let hasDone = false;
        let doneOperation = "";

        switch(operation){
            case 'cut':{
                doneOperation = "Cut";
                while(currentResult / 4 >= targetThickness){
                    currentResult /= 4;
                    count++;
                    hasDone = true;
                }
                break;
            }
            case 'lap':{
                doneOperation = "Lap";
                while(currentResult * 0.8 >= targetThickness){
                    currentResult *= 0.8;
                    count++;
                    hasDone = true;
                }
                break;
            }
            case 'grind':{
                doneOperation = "Grind";
                while(currentResult - 20 >= targetThickness){
                    currentResult -= 20;
                    count++;
                    hasDone = true;
                }
                break;
            }
            case 'etch':{
                doneOperation = "Etch";
                while(currentResult - 2 >= targetThickness - 1){
                    currentResult -= 2;
                    count++;
                    hasDone = true;
                }
                break;
            }
        }

        if(hasDone){
            console.log(`${doneOperation} x${count}`);
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
                currentResult = doOperation(currentResult, targetThickness, 'cut');
            }
            else if(operationIndex == 2){
                currentResult = doOperation(currentResult, targetThickness, 'lap');
            }
            else if(operationIndex == 3){
                currentResult = doOperation(currentResult, targetThickness, 'grind');
            }
            else if(operationIndex == 4){
                currentResult = doOperation(currentResult, targetThickness, 'etch');
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


