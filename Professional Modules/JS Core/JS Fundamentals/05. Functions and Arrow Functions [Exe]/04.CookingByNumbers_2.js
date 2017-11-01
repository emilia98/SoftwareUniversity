function cookByNumbers(array){
    let number = Number(array[0]);
    let result = number;

    let chop = function(num){ return num / 2;};
    let dice = function(num) { return Math.sqrt(num);};
    let spice = function(num) { return ++num; };
    let bake = function(num) { return num * 3; };
    let fillet = function(num) { return num * 0.8; };

    let doOperation = function(num, operation) {
        switch(operation){
            case "chop": { return doOperation(num, chop); }
            case "dice": {  return doOperation(num, dice);}
            case "spice": { return doOperation(num, spice); }
            case "bake": { return doOperation(num, bake); }
            case "fillet": { return doOperation(num, fillet);}
        }
        return operation(num);
    };

    for(let index = 1; index < array.length; index++){
        let operation = array[index];
        result = doOperation(result, array[index]);
        console.log(result);
    }
}

/* Uncomment to test:
cookByNumbers([32,"chop", "chop", "chop", "chop", "chop"]);
cookByNumbers([9, "dice", "spice", "chop", "bake", "fillet"]);
*/