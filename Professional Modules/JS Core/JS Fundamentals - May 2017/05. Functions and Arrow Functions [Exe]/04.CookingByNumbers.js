function cookByNumbers(array){
    "use strict";
    let number = Number(array[0]);
    let result = number;

    for(let index = 1; index < array.length; index++){
        result = doOperation(result, array[index]);
        console.log(result);
    }

    function doOperation(num, operation){
        if(operation == "chop"){
            return num / 2;
        }
        else if(operation == "dice"){
            return Math.sqrt(num);
        }
        else if(operation == "spice"){
            return ++num;
        }
        else if(operation == "bake"){
            return num * 3;
        }
        else if(operation == "fillet"){
            return num * 0.8;
        }
    }
}

/* Uncomment to test:
cookByNumbers([32,"chop", "chop", "chop", "chop", "chop"]);
cookByNumbers([9, "dice", "spice", "chop", "bake", "fillet"]);
*/