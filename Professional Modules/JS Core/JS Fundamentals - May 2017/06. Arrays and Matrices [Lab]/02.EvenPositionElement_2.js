function printEvenPositionElements(array){
    let evenPositionedArray = [];
    for(let i in array){
       if(i % 2 == 0){
           evenPositionedArray.push(array[i]);
       }
    }
    console.log(evenPositionedArray.join(" "));
}

/* Uncomment to test:
printEvenPositionElements(['20', '30', '40']);
printEvenPositionElements(['5', '10']);
*/
