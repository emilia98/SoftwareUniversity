function printEvenPositionElements(array){
    console.log(array.filter((el, i) => i % 2 == 0).join(" "));
}

/* Uncomment to test:
printEvenPositionElements(['20', '30', '40']);
printEvenPositionElements(['5', '10']);
*/