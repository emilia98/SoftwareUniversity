function attachEvents(){
    $("#items").on("click", "li", function() {
        let li = $(this);

        if(li.attr('data-selected')){
            li.removeAttr("data-selected");
            li.css("background-color", "");
        } else{
            li.attr("data-selected", "true");
            li.css("background-color", "#DDD");
        }
    });

    $("#showTownsButton").on("click", function(){
        let towns = $("#items li[data-selected]").toArray().map(li => li.textContent).join(", ");
        $('#selectedTowns').text(`Selected towns: ${towns}`);
    });
}