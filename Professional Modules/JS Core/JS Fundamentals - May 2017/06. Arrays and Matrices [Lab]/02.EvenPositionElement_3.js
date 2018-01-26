function printEvenPositionElements(array){
    let evenPositionedArray = [];
    for(let index = 0; index < array.length; index++){
        if(index % 2 == 0){
            evenPositionedArray.push(array[index]);
        }
    }
    console.log(evenPositionedArray.join(" "));
}

/*Uncomment to test:
printEvenPositionElements(['20', '30', '40']);
printEvenPositionElements(['5', '10']);
printEvenPositionElements(['20', '30', '40', '50', '60', '1']);
*/
