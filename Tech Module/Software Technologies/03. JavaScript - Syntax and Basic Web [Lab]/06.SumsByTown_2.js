function sumByTowns(array){
    let objects = array.map(JSON.parse);
    let sumsByTowns = {};

    for(let object of objects){
        if(object.town in sumsByTowns){
            sumsByTowns[object.town] += object.income;
        } else{
            sumsByTowns[object.town] = object.income;
        }
    }
    let sortedTowns = Object.keys(sumsByTowns).sort();

    for (let town of sortedTowns) {
        console.log(`${town} -> ${sumsByTowns[town]}`)
    }
}

/* Uncomment to test:
sumByTowns(['{"town":"Sofia","income":200}',
            '{"town":"Varna","income":120}',
            '{"town":"Pleven","income":60}',
            '{"town":"Varna","income":70}']);
*/