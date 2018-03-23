function attachEvents(){
    $('#items').children().click(clickElement);
    $('#showTownsButton').click(showTowns);

    function clickElement(){
        if($(this).attr("data-selected") === undefined){
            $(this).attr("data-selected", "true");
            $(this).css("background-color", "#DDD");
        }else{
            $(this).removeAttr("data-selected");
            $(this).removeAttr("style");
        }
    }
    
    function showTowns() {
        let towns = $("#items li[data-selected]").toArray().map(li => li.textContent);
        $('#selectedTowns').text(`Selected towns: ${towns.join(", ")}`);
    }
}