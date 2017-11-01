function calculateTripLength(array){
    array.map(el => Number(el));
    let point1 = {x: array[0], y: array[1]};
    let point2 = {x: array[2], y: array[3]};
    let point3 = {x: array[4], y: array[5]};

    let distance1To2 = findDistance(point1, point2);
    let distance2To3 = findDistance(point2, point3);
    let distance1To3 = findDistance(point1, point3);

    let result = "";
    let totalShortestDistances = 0;
    //Shortest from 1 to 3  =>   1 -> 2 -> 3
    if ((distance1To2 <= distance1To3) &&
        (distance2To3 <= distance1To3)) {
        result = "1->2->3";
        totalShortestDistances = distance1To2 + distance2To3;
    }
    //Shortest from 2 to 3  =>  2 -> 1 -> 3
    else if ((distance1To2 <= distance2To3) &&
        (distance1To3 < distance2To3)) {
        result = "2->1->3";
        totalShortestDistances = distance1To2 + distance1To3;
    }
    //Shortest from 1 to 2  => 1 -> 3 -> 2
    else {
        result = "1->3->2";
        totalShortestDistances = distance2To3 + distance1To3;
    }
    console.log(`${result}: ${totalShortestDistances}`);

    function findDistance(p1, p2) {
        let distX = Math.abs(p1.x - p2.x);
        let distY = Math.abs(p1.y - p2.y);
        let distance = Math.sqrt(distX * distX + distY * distY);
        return distance;
    }
}

/* Uncomment to test:
calculateTripLength([0, 0, 2, 0, 4, 0]);
calculateTripLength([5, 1, 1, 1, 5, 4]);
calculateTripLength([-1, -2, 3.5, 0, 0, 2]);
calculateTripLength([0, 3, 1, 0,-1, 0]);
*/