// Here I choose to have an input as a string, not as an array
function roundingNumbers(input){
    let array = input.split(' ').map(el => Number(el));

    for(let index = 0; index < array.length; index++){
        let number = array[index];

        let diff = Math.abs(number - parseInt(number));

        if(diff >= 0.5){
            array[index]  = array[index] > 0 ?
                            parseInt(number) + 1 :  parseInt(number) - 1;
        }
        else{
            array[index] = parseInt(number);
        }
        console.log(`${number} => ${array[index]}`);
    }
}

roundingNumbers("0.9 1.5 2.4 2.5 3.14");
roundingNumbers("-5.01 -1.599 -2.5 -1.50 0 -5.6");