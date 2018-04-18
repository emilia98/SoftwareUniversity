function move(command) {
    let availableTowns = document.querySelectorAll("#available-towns option");
    let selectedTowns = document.querySelectorAll("#selected-towns option");
    let output = document.getElementById("output");

    if(command === "right"){
        let selected = findSelected(availableTowns);
        moveTown(selected, "selected-towns");
    }

    else if(command === "left"){
        let selected = findSelected(selectedTowns);
        moveTown(selected, "available-towns");
    }

    else if(command === "print"){
        let result = [];

        for(let town of selectedTowns){
            result.push(town.textContent);
        }

        output.textContent = result.join("; ");
    }

    function findSelected(towns){
        for(let town of towns){
            if(town.selected){
                return town;
            }
        }
        return null;
    }

    function moveTown(town, selectedList){
        if(town){
            let moveTo = document.getElementById(selectedList);
            moveTo.appendChild(town);
        }
    }
}
