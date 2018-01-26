function getRadarData(array) {
    let speed = Number(array[0]);
    let areaOfDriving = array[1];

    let speedLimit = getLimit(areaOfDriving);
    let result = getBehaviour(speed, speedLimit);

    if(result != "normal"){
        console.log(result);
    }

    function getLimit(area){
        switch(area){
            case "residential":{
                return 20;
            }
            case "city":{
                return 50;
            }
            case "interstate":{
                return 90;
            }
            case "motorway":{
                return 130;
            }
        }
    }

    function getBehaviour(speed, speedLimit){
        if(speed <= speedLimit){
            return "normal";
        }
        else if(speed - speedLimit <= 20){
            return "speeding";
        }
        else if(speed - speedLimit <= 40){
            return "excessive speeding";
        }
        else{
            return "reckless driving";
        }
    }
}

/* Uncomment to test:
getRadarData([40, "city"]);
getRadarData([21, "residential"]);
getRadarData([120, "interstate"]);
getRadarData([200, "motorway"]);
*/