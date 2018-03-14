function stringifyConcerts(arr){
    let concertsData = {};
    arr = arr.filter(el => el !== "");

    for(let concert of arr){
        let [band, town, date, venue] = concert.split('|').map(el => el.trim());

        if(!(town in concertsData)){
            concertsData[town] = {};
        }

        if(!(venue in concertsData[town])){
            concertsData[town][venue] = [];
        }

        if(!concertsData[town][venue].includes(band)){
            concertsData[town][venue].push(band);
        }
    }

    let sortedObj = {};
    let towns = Object.keys(concertsData).sort()

    for(let town of towns){
        let stadiums = Object.keys(concertsData[town]).sort();
        sortedObj[town] = {};

        stadiums.forEach(stadium => {
            sortedObj[town][stadium] = [];
            let bands = concertsData[town][stadium].sort().slice(0);
            sortedObj[town][stadium] = bands;
        })
    }
    console.log(JSON.stringify(sortedObj));
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
