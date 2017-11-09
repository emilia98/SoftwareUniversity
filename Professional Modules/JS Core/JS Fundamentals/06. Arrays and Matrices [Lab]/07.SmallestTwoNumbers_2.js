function findTwoSmallestElements(array){
    array.sort((a, b) => a - b);
    let smallestTwo = array.slice(0, 2);
    console.log(smallestTwo.join(" "));
}

/*Uncomment to test:
findTwoSmallestElements([30, 15, 50, 5]);
findTwoSmallestElements([3, 0, 10, 4, 7, 3]);
*/
