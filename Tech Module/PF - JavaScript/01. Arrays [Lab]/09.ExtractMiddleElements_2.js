function extractMiddleElements(array){
    let size = array.length;

    if(size == 1){
        console.log(`{ ${array[0]} }`);
    }
    else if(size % 2 == 0){
        let startIndex = (parseInt(size / 2)) - 1;
        let num1 = array[startIndex];
        let num2 = array[startIndex + 1];
        console.log(`{ ${num1}, ${num2} }`);
    }
    else{
        let startIndex = (parseInt(size / 2));
        let num1 = array[startIndex - 1];
        let num2 = array[startIndex];
        let num3 = array[startIndex + 1];
        console.log(`{ ${num1}, ${num2}, ${num3} }`);
    }
}

extractMiddleElements([5]);
extractMiddleElements([2, 3, 8, 1, 7, 4]);
extractMiddleElements([1, 2, 3, 4, 5, 6, 7]);
extractMiddleElements([10, 20, 30, 40, 50, 60, 70, 80]);