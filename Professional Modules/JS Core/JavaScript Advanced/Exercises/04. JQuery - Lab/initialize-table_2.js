// if fadeIn() is after changeLinks(), there is Time Limit in Judge
function initializeTable(){
    $("#createLink").click(createRow);

    create("Bulgaria", "Sofia");
    create("Germany", "Berlin");
    create("Russia", "Moscow");

    function createRow(){
        let countryText = $("#newCountryText");
        let capitalText = $("#newCapitalText");

        create(countryText.val(), capitalText.val());
        countryText.val("");
        capitalText.val("");
    }

    function create(country, capital){
        let row = $('<tr>')
                    .append($(`<td>${country}</td>`))
                    .append($(`<td>${capital}</td>`))
                    .append($('<td>')
                    .append($('<a href="#">[Up]</a> ').click(moveUp))
                    .append($('<a href="#">[Down]</a> ').click(moveDown))
                    .append($('<a href="#">[Delete]</a>').click(deleteRow)));
            //.appendTo($('#countriesTable'));
        row.css("dispay", "none");
        row.appendTo($('#countriesTable'));
        row.fadeIn();

        changeLinks();
    }


    function moveUp(){
        let current = $(this).parent().parent();

        current.fadeOut(() => {
            current.insertBefore($(current).prev());
            current.fadeIn();
            changeLinks();
        });
    }

    function moveDown(){
        let current = $(this).parent().parent();

        current.fadeOut(() => {
            current.insertAfter($(current.next()));
            current.fadeIn();
            changeLinks();
        })
    }

    function deleteRow(){
        let current = $(this).parent().parent();
        current.fadeOut(() => {
            current.remove();
            changeLinks();
        });
    }

    function changeLinks() {
        $("#countriesTable a").show();
        let rows = $("#countriesTable tr");

        $(rows[2]).find("a:contains('Up')").hide();
        $(rows[rows.length - 1]).find("a:contains('Down')").hide();
    }
}