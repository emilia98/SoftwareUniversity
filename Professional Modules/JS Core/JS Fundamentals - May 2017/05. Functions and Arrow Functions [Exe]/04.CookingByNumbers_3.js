function cookByNumbers(array){
    let [start, oper1, oper2, oper3, oper4, oper5] =
        [Number(array[0]), array[1], array[2], array[3],
            array[4], array[5]];

    let chop = (num) => num / 2;
    let dice = (num) => Math.sqrt(num);
    let spice = (num) => ++num;
    let bake = (num) => num * 3;
    let fillet = (num) => num *= 0.8;

    let result = start;
    for(let operation of [oper1, oper2, oper3, oper4, oper5]){
        switch(operation){
            case 'chop':{
                result = chop(result);
                break;
            }
            case 'dice':{
                result = dice(result);
                break;
            }
            case 'spice':{
                result = spice(result);
                break;
            }
            case 'bake':{
                result = bake(result);
                break;
            }
            case 'fillet':{
                result = fillet(result);
                break;
            }
        }
        console.log(result);
    }
}

/* Uncomment to test:
cookByNumbers([32,"chop", "chop", "chop", "chop", "chop"]);
cookByNumbers([9, "dice", "spice", "chop", "bake", "fillet"]);
*/
