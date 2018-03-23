function domSearch(selector, cs = false){
    let divResult = $('<div>').attr("class", "result-controls");
    let items = $('<ul class="items-list"></ul>');
    divResult.append(items);

    let divAdd = $('<div>')
                        .attr("class", "add-controls")
                        .append($('<label for="add">Enter text:</label>')
                        .append('<input type="text" val="" id="add"/>'))
                                 .append($('<a class="button">Add</a>')                                               .click(addEntry));

    let divSearch = $('<div class="search-controls"></div>')
                            .append($('<label for="search">Search:</label>')                           .append($('<input type="text" val="" id="search"/>')                                 .change(searchFor)));

    $(selector).append(divAdd);
    $(selector).append(divSearch);
    $(selector).append(divResult);

    function addEntry(){
        let text = $('#add');
        let li = $('<li class="list-item"></li>');
        li.append($('<a class="button">X</a>').click(deleteEntry))
          .append(`<strong>${text.val()}</strong>`);

        items.append(li);
        text.val("");
    }
    
    function deleteEntry() {
        $(this).parent().remove();
    }

    function searchFor(){
        let pattern = $(this).val();
        let elementsToCheck = $('ul.items-list li.list-item strong');

        if(cs){
            elementsToCheck.each((index, element) => {
                if(element.textContent.includes(pattern)){
                    $(element).parent().removeAttr("style");
                }else{
                    $(element).parent().css("display", "none");
                }
            })
        }
        else{
            pattern = pattern.toLowerCase();
            elementsToCheck.each((index, element) => {
                if(element.textContent.toLowerCase().includes(pattern)){
                    $(element).parent().removeAttr("style");
                }else{
                    $(element).parent().css("display", "none");
                }
            })
        }
    }
}