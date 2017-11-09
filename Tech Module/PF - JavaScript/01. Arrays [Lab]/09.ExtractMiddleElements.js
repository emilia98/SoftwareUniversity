function extractMiddleElements(array){
    let size = array.length;
    let middleElements = [];

    if(size == 1){
        middleElements.push(array[0]);
    }
    else{
        let counter = size % 2 == 0 ? 2 : 3;
        let startIndex = parseInt(size / 2) - 1 ;
        for(let cnt = 0; cnt < counter; cnt++){
            middleElements.push(array[startIndex + cnt]);
        }
    }
    console.log(`{ ${middleElements.join(", ")} }`);
}

extractMiddleElements([5]);
extractMiddleElements([2, 3, 8, 1, 7, 4]);
extractMiddleElements([1, 2, 3, 4, 5, 6, 7]);
extractMiddleElements([10, 20, 30, 40, 50, 60, 70, 80]);