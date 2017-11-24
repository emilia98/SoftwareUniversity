function calculateAfterHeists(arr1, arr2){
    let priceOfJewels = parseInt(arr1[0]);
    let priceOfGold = parseInt(arr1[1]);

    let totalMoney = 0;

    for(let heist of arr2){
        if(heist == "Jail Time"){
            break;
        }

        let splitHeist = heist.split(' ');
        let loot = splitHeist[0];
        let expenses = parseInt(splitHeist[1]);

        let jewelsCount = 0;
        let goldCount = 0;

        for(let index in loot){
            if(loot[index] == '%') {
                jewelsCount++;
            }else if(loot[index] == '$'){
                goldCount++;
            }
        }

        let earnings = (jewelsCount * priceOfJewels) + (goldCount * priceOfGold);
        totalMoney += (earnings - expenses);
    }

    if(totalMoney >= 0){
        console.log(`Heists will continue. Total earnings: ${totalMoney}.`);
    }else{
        console.log(`Have to find another job. Lost: ${Math.abs(totalMoney)}.`);
    }
}

calculateAfterHeists(["10", "20"],
    ["ASDA% 50", "DaS@!%$$ 10", "$$ 10", "Jail Time"]);
calculateAfterHeists(["2000", "10000"],
    ["ASDAs 500000", "%ASD$ 1000000", "$S$&*_ASD 1000", "AF#^&*LP 20000",
        "$ 100000000", "Jail Time"]);
