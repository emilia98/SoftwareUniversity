function rotateArray(array){
    let size = array.length;
    let rotations = parseInt(array[size - 1]);

    rotations = rotations % (size - 1);
    array = array.slice(0, size - 1);

    for(let rotation = 1; rotation <= rotations; rotation++){
        let lastElement = array.pop();
        array.unshift(lastElement);
    }
    console.log(array.join(" "));
}

/* Uncomment to test:
rotateArray(["1", "2", "3", "4", "2"]);
rotateArray(["Banana", "Orange", "Coconut", "Apple", "15"]);
*/
