function printDNA(arg){
    let number = parseInt(arg);
    let helix = ["AT", "CG", "TT", "AG", "GG"];

    for(let counter = 0; counter < number; counter++){
        getEachLine(counter, helix);
    }

    function getEachLine(counter, helix){
        let index = (counter) % 5;
        let combination = helix[index];
        let letter1 = combination[0];
        let letter2 = combination[1];
        let rowNumber = counter % 4;

        console.log(printTheHelix(letter1, letter2, rowNumber));
    }

    function printTheHelix(letter1, letter2, rowNumber){
        let result = "";
        if(rowNumber == 0){
            result = "**" + letter1 + letter2 + "**";
        }
        else if(rowNumber == 1 || rowNumber == 3){
            result = "*" + letter1 + "--" + letter2 + "*";
        }
        else{
            result = letter1 + "----" + letter2;
        }
        return result;
    }
}

/* Uncomment to test:
printDNA(4);
printDNA(10);
*/