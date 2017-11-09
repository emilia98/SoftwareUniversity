function rotateArray(array){
    let n = parseInt(array.pop());
    let rotations = n % array.length;

    for(let rotation = 1; rotation <= rotations; rotation++){
        let lastElement = array.pop();
        array.unshift(lastElement);
    }
    console.log(array.join(" "));
}

/* Uncomment to test
rotateArray(["1", "2", "3", "4", "2"]);
rotateArray(["Banana", "Orange", "Coconut", "Apple", "15"]);
*/