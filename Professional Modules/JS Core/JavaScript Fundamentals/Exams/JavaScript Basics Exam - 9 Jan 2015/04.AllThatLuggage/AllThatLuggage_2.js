// With Map
// WIth another kind of spliting
// Another kind of sorting
function printInfoAboutLuggage(arr){
    arr = arr.filter(el => el !== "");
    let sortCriteria = arr.pop();
    let luggageInfo = {};

    for(let sheet of arr){
        let [owner, luggageName, isFood, isDrink, isFragile, weight, transferredWith] = sheet.split(/\.*\*\.*/g);

        if(!(owner in luggageInfo)){
            luggageInfo[owner] = {}
        }

        // ??? Are there repeating luggageNames ???
        luggageInfo[owner][luggageName] = {
            kg: Number(weight),
            fragile: isFragile === "true" ? true : false,
            type: checkLuggageType(isFood, isDrink),
            transferredWith
        };
    }

    let sortedObj = {};
    if(sortCriteria === "strict"){
        sortedObj = luggageInfo;
    }else{
        sortedObj = sortObject(sortCriteria);
    }

    console.log(JSON.stringify(sortedObj));

    function checkLuggageType(isFood, isDrink){
        if(isFood === "true"){
            return "food";
        }
        if(isDrink === "true"){
            return "drink";
        }
        return "other";
    }

    function sortObject(sortCriteria){
        let sortedObj = {};

        for(let owner in luggageInfo){
            sortedObj[owner] = {};
            let luggageNames = Object.keys(luggageInfo[owner]).sort(sortFunction(sortCriteria, owner));
            luggageNames.forEach(el => {
                sortedObj[owner][el] = luggageInfo[owner][el];
            });
        }
        return sortedObj;
    }

    function sortFunction(sortCriteria, owner){
        if(sortCriteria === "weight"){
            return (a, b) => {
                let A_kg = luggageInfo[owner][a].kg;
                let B_Kg = luggageInfo[owner][b].kg;

                return A_kg - B_Kg;
            };
        }
        return (a, b) => {
            if(a > b) return 1;
            if(a < b) return -1;
            return 0;
        };
    }
}

/* Uncomment to test:
printInfoAboutLuggage([
    "Yana Slavcheva.*.clothes.*.false.*.false..*....false.*.2.2.*.backpack",
    "Kiko.*.socks.*.false.*.false.*....false.*.0.2.*.backpack",
    "Kiko.*.banana.*.true.*.false.*false.*.3.2.*.backpack",
    "Kiko.*.sticks.*.false.*.false*.false.*.1.6.*.ATV",
    "Kiko.*.glasses.*.false.*.false.*...true.*.3.*.ATV",
    "Manov.*.socks.*.false.*.false. *.false.*.0.3*.ATV",
    "strict",
    ""
]);

printInfoAboutLuggage([
    "Yana Slavcheva.*.clothes.*.false.*.false..*....false.*.2.2.*.backpack",
    "Kiko.*.socks.*.false.*.false.*....false.*.0.2.*.backpack",
    "Kiko.*.banana.*.true.*.false.*false.*.3.2.*.backpack",
    "Kiko.*.sticks.*.false.*.false*.false.*.1.6.*.ATV",
    "Kiko.*.glasses.*.false.*.false.*...true.*.3.*.ATV",
    "Manov.*.socks.*.false.*.false. *.false.*.0.3*.ATV",
    "weight",
    ""
]);

printInfoAboutLuggage([
    "Yana Slavcheva.*.clothes.*.false.*.false..*....false.*.2.2.*.backpack",
    "Kiko.*.socks.*.false.*.false.*....false.*.0.2.*.backpack",
    "Kiko.*.banana.*.true.*.false.*false.*.3.2.*.backpack",
    "Kiko.*.sticks.*.false.*.false*.false.*.1.6.*.ATV",
    "Kiko.*.glasses.*.false.*.false.*...true.*.3.*.ATV",
    "Manov.*.socks.*.false.*.false. *.false.*.0.3*.ATV",
    "luggage name",
    ""
]);
*/