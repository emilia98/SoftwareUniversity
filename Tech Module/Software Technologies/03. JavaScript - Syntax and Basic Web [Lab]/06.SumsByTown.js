function sumByTowns(array){
    let objects = array.map(JSON.parse);
    let sumsByTowns = {};

    for(let object of objects){
        let town = object['town'];
        let income = object['income'];

        if(!(town in sumsByTowns)){
            sumsByTowns[town] = 0;
        }
        sumsByTowns[town] += income;
    }

    let sortedTowns = Object.keys(sumsByTowns).sort();

    sortedTowns.forEach(town => console.log(`${town} -> ${sumsByTowns[town]}`));
}

/* Uncomment to test:
sumByTowns(['{"town":"Sofia","income":200}',
            '{"town":"Varna","income":120}',
            '{"town":"Pleven","income":60}',
            '{"town":"Varna","income":70}']);
*/