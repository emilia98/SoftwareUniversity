function aggregateTable(array){
    let townsList = [];
    let incomes = 0;

    for(let row of array){
        let splitRow = row.split(/[\s\|]+/).filter(el => el != "");
        let size = splitRow.length;

        let town = size == 2 ? splitRow[0] : getNameOfTown(splitRow);
        townsList.push(town);
        incomes += Number(splitRow[size - 1]);
    }

    console.log(townsList.join(", "));
    console.log(incomes);

    function getNameOfTown(str){
        let result = str[0];

        for(let i = 1; i < str.length - 1; i++){
            result += " " + str[i];
        }

        return result;
    }
}


/* Uncomment to test:
aggregateTable(['| Sofia           | 300',
    '| Veliko Tarnovo  | 500',
    '| Yambol          | 275']
);
aggregateTable(['|   Stara Nova Zagora           |750',
    '| Lovech  | 500',
    '|Gabrovo| 875']
);
*/