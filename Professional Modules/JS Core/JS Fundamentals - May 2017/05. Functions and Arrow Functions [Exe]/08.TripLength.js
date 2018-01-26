function calculateTripLength(array){
    array.map(el => Number(el));
    let points = [];
    let distancesInfo = [];

    points = getCoordinates(points, array);
    distancesInfo = calculateDistances(points, distancesInfo);

    printResults(distancesInfo);

    function getCoordinates(points, array) {
        for(let index = 0; index < array.length; index += 2){
            let point  = {
                x: array[index],
                y: array[index + 1]
            };
            points.push(point);
        }
        return points;
    }

    function calculateDistances(points, distancesInfo){
        distancesInfo.push(findDistance(points[0], points[1])); // 1 -> 2
        distancesInfo.push(findDistance(points[1], points[2])); // 2 -> 3
        distancesInfo.push(findDistance(points[0], points[2])); // 1 -> 3
        return distancesInfo;
    }

    function printResults(distancesInfo){
        let result = "";
        let totalShortestDistances = 0;
        //Shortest from 1 to 3  =>   1 -> 2 -> 3
        if ((distancesInfo[0] <= distancesInfo[2]) &&
            (distancesInfo[1]) <= distancesInfo[2]) {
            result = "1->2->3";
            totalShortestDistances = distancesInfo[0] + distancesInfo[1];
        }
        //Shortest from 2 to 3  =>  2 -> 1 -> 3
        else if ((distancesInfo[0] <= distancesInfo[1]) &&
            (distancesInfo[2] < distancesInfo[1])) {
            result = "2->1->3";
            totalShortestDistances = distancesInfo[0] + distancesInfo[2];
        }
        //Shortest from 1 to 2  => 1 -> 3 -> 2
        else {
            result = "1->3->2";
            totalShortestDistances = distancesInfo[1] + distancesInfo[2];
        }
        console.log(`${result}: ${totalShortestDistances}`);
    }

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