function checkIfInsideVolume(array) {
    for(let index = 0; index < array.length; index += 3){
        let pointCoordinates = {
            x: Number(array[index]),
            y: Number(array[index + 1]),
            z: Number(array[index + 2])
        };

        if(isInside(pointCoordinates)){
            console.log("inside");
        }
        else{
            console.log("outside");
        }
    }

    function isInside(point){
        let point1 = { x: 10, y: 20, z: 15};
        let point2 = { x: 50, y: 80, z: 50};

        if(point.x >= point1.x && point.x <= point2.x){
            if(point.y >= point1.y && point.y <= point2.y){
                if(point.z >= point1.z && point.z <= point2.z){
                    return true;
                }
            }
        }
        return false;
    }
}

/* Uncomment to test:
checkIfInsideVolume([8, 20, 22]);
checkIfInsideVolume([13.1, 50, 31.5, 50, 80, 50, -5, 18, 43]);
*/