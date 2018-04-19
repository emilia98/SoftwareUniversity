function calculateTotalFuel(arr){
    arr = arr.filter(el => el !== "");

    for(let car of arr){
        let [carModel, fuelType, routeNumber, luggageWeight] = car.split(" ");
        [routeNumber, luggageWeight] = [routeNumber, luggageWeight].map(el => Number(el));

        let fuelConsumption = getLitersPerHundredKm(fuelType);
        fuelConsumption += luggageWeight * 0.01;

        let totalConsumation = calculateTotalFuel(routeNumber, fuelConsumption);

        console.log(`${carModel} ${fuelType} ${routeNumber} ${Math.round(totalConsumation)}`);
    }

    function getLitersPerHundredKm(fuelType){
        switch(fuelType){
            case "gas": {
                return 12;
            }
            case "petrol": {
                return 10;
            }
            case "diesel": {
                return 8;
            }
        }
    }

    function calculateTotalFuel(route, fuelConsumption){
        let snowyParts = 0;
        let totalDistance = 0;

        if(route === 1){
            snowyParts = 10;
            totalDistance = 110;
        }else if(route === 2){
            snowyParts = 30;
            totalDistance = 95;
        }

        let totalFuel = 0;
        let litersPerOneKm = fuelConsumption / 100;
        totalFuel = litersPerOneKm * totalDistance;
        totalFuel += 0.3 * snowyParts * litersPerOneKm ;

        return totalFuel;

    }
}

/* Uncomment to test:
calculateTotalFuel(['BMW petrol 1 320.5',
    'Golf petrol 2 150.75',
    'Lada gas 1 202',
    'Mercedes diesel 2 312.54',
    ""
    ]
);
*/
