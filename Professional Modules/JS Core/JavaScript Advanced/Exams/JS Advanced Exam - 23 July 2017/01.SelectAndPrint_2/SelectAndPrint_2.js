function move(command) {
    let availableTowns = $('#available-towns');
    let selectedTowns = $('#selected-towns');
    let output = $("#output");

    if(command === "right"){
        let selected = $("#available-towns").find(":selected");
        moveTown(selected, selectedTowns);
    }

    else if(command === "left"){
        let selected = selectedTowns.find(":selected");
        moveTown(selected, availableTowns);
    }

    else if(command === "print"){
        let allSelected = selectedTowns.find("option");
        output.text([...allSelected].map(el => $(el).text()).join("; "));
    }

    function moveTown(town, selectedList){
        if(town){
            $(selectedList).append(town);
        }
    }
}