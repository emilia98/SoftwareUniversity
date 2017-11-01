function printLocator(array){

    for(let index = 0; index < array.length - 1; index += 2){
        let coordinates = {
            x: Number(array[index]),
            y: Number(array[index + 1]),
        }
        console.log(checkForTreasure(coordinates));
    }

    function checkForTreasure(coordinates){
        if((coordinates.x >= 1 && coordinates.x <= 3)
          && (coordinates.y >= 1 && coordinates.y <= 3)){
            return "Tuvalu";
        }
        else if((coordinates.x >= 0 && coordinates.x <= 2)
            && (coordinates.y >= 6 && coordinates.y <= 8)){
            return "Tonga";
        }
        else if((coordinates.x >= 5 && coordinates.x <= 7)
            && (coordinates.y >= 3 && coordinates.y <= 6)){
            return "Samoa";
        }
        else if((coordinates.x >= 8 && coordinates.x <= 9)
            && (coordinates.y >= 0 && coordinates.y <= 1)){
            return "Tokelau";
        }
        else if((coordinates.x >= 4 && coordinates.x <= 9)
            && (coordinates.y >= 7 && coordinates.y <= 8)){
            return "Cook";
        }
        else{
            return "On the bottom of the ocean";
        }
    }
}

/* Uncomment to test:
printLocator([4, 2, 1.5, 6.5, 1, 3]);
printLocator([6, 4]);
*/