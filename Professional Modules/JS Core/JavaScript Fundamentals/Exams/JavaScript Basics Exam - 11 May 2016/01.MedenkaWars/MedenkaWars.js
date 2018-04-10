function printWinner(arr){
    let vitkor = {
        damageDealt: 0,
        normalAttacks: 0,
        previous: null
    };

    let naskor = {
        damageDealt: 0,
        normalAttacks: 0,
        previous: null
    };

    for(let attack of arr){
        let tokens = attack.split(" ").filter(el => el !== "");
        let medenkasCount = parseInt(tokens[0]);
        let attackType = tokens[1];

        if(attackType === "white"){
            if(vitkor.previous !== medenkasCount){
                vitkor.normalAttacks = 1;
                vitkor.damageDealt += medenkasCount * 60;
            }else{
                vitkor.normalAttacks++;

                if(vitkor.normalAttacks === 2){
                    vitkor.damageDealt += 2.75 * medenkasCount * 60;
                    vitkor.normalAttacks = 0;
                }else{
                    vitkor.damageDealt += medenkasCount * 60;
                }
            }
            vitkor.previous = medenkasCount;
        }

        if(attackType === "dark"){
            if(naskor.previous !== medenkasCount){
                naskor.normalAttacks = 1;
                naskor.damageDealt += medenkasCount * 60;
            }else{
                naskor.normalAttacks++;
                if(naskor.normalAttacks === 5){
                    naskor.damageDealt += 4.5 * medenkasCount * 60;
                    naskor.normalAttacks = 1;
                }else{
                    naskor.damageDealt += medenkasCount * 60;
                }
            }
            naskor.previous = medenkasCount;
        }
    }

    let winner = findWinner();

    console.log(`Winner - ${winner.name}`);
    console.log(`Damage - ${winner.damage}`);

    function findWinner() {
        let winner = {};

        if(vitkor.damageDealt > naskor.damageDealt){
            winner.name = "Vitkor";
            winner.damage = vitkor.damageDealt;
        }else{
            winner.name = "Naskor";
            winner.damage = naskor.damageDealt;
        }
        return winner;
    }
}

/* Uncomment to test:
printWinner([
    " 5 white medenkas",
    "5   dark medenkas",
    "4 white medenkas  "
]);

printWinner([
    "2 dark medenkas",
    "1 white medenkas",
    "2 dark medenkas",
    "2 dark medenkas",
    "15 white medenkas",
    "2 dark medenkas",
    "2 dark medenkas",
])

printWinner([
    " 5 white medenkas",
    "5   dark medenkas",
    "5 white medenkas  ",
    "5   dark medenkas",
    "5   dark medenkas",
    "5 white medenkas  ",
]);
*/