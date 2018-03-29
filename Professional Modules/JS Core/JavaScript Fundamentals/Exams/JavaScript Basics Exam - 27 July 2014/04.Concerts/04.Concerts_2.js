function stringifyConcerts(arr){
    let concertsData = new Map();
    arr = arr.filter(el => el !== "");

    for(let concert of arr){
        let [band, town, date, venue] = concert.split('|').map(el => el.trim());

        if(!concertsData.has(town)){
            concertsData.set(town, new Map());
        }

        if(!concertsData.get(town).has(venue)){
            concertsData.get(town).set(venue, []);
        }

        if(!concertsData.get(town).get(venue).includes(band)){
            concertsData.get(town).get(venue).push(band);
        }
    }

    let sortedObject = {};
    let towns = [...concertsData.entries()].map(k => k[0]).sort();

    for(let town of towns){
        sortedObject[town] = {};

        let stadiums = [...concertsData.get(town).entries()].map(k => k[0]).sort();

        for(let stadium of stadiums){
            sortedObject[town][stadium] = concertsData.get(town).get(stadium).sort();
        }
    }
    console.log(JSON.stringify(sortedObject));
}

/* Uncomment to test:
stringifyConcerts(["ZZ Top | London | 2-Aug-2014 | Wembley Stadium",
    "Iron Maiden | London | 28-Jul-2014 | Wembley Stadium",
    "Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium",
    "Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium",
    "Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium",
    "Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium",
    "Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium",
    "Helloween | London | 28-Jul-2014 | Wembley Stadium",
    "Twisted Sister | London | 30-Sep-2014 | Wembley Stadium",
    "Metallica | London | 03-Oct-2014 | Olympic Stadium",
    "Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium",
    "Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium",
    ""]);
*/
