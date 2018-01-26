function calculateTripLength(array){
    array.map(el => Number(el));
    let [x1, y1, x2, y2, x3, y3] = [array[0], array[1], array[2], array[3], array[4], array[5]];

    let distance1To2 = Math.sqrt(Math.pow((x1 - x2) , 2) + Math.pow((y1 - y2) , 2));
    let distance2To3 = Math.sqrt(Math.pow((x2 - x3) , 2) + Math.pow((y2 - y3) , 2));
    let distance1To3 = Math.sqrt(Math.pow((x1 - x3) , 2) + Math.pow((y1 - y3) , 2));

    if ((distance1To2 <= distance1To3) && (distance2To3 <= distance1To3)) {
        console.log("1->2->3: " + (distance1To2 + distance2To3));
    }
    else if ((distance1To2 <= distance2To3) && (distance1To3 < distance2To3)) {
        console.log("2->1->3: " + (distance1To2 + distance1To3));
    }
    else {
        console.log("1->3->2: " + (distance2To3 + distance1To3));
    }
}

/* Uncomment to test:
calculateTripLength([0, 0, 2, 0, 4, 0]);
calculateTripLength([5, 1, 1, 1, 5, 4]);
calculateTripLength([-1, -2, 3.5, 0, 0, 2]);
calculateTripLength([0, 3, 1, 0,-1, 0]);
*/