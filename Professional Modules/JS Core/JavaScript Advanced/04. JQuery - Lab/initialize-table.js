function initializeTable(){
    let countriesTable = $('#countriesTable');
    $('#createLink').on("click", createNewEntry);

    create("Bulgaria", "Sofia");
    create("Germany", "Berlin");
    create("Russia", "Moscow");

    function createNewEntry() {
        let newCountry = $('#newCountryText').val();
        let newCapital = $('#newCapitalText').val();

        create(newCountry, newCapital);
    }

    function create(country, capital){
        let row = $('<tr>');

        $(row).append($(`<td>${country}</td>`));
        $(row).append($(`<td>${capital}</td>`));
        let linksCol = $('<td>');
        $(linksCol).append($('<a href="#" id="up">[Up]</a>').on("click", moveUp));
        $(linksCol).append(" ");
        $(linksCol).append($('<a href="#" id="down">[Down]</a>').on("click", moveDown));
        $(linksCol).append(" ");
        $(linksCol).append($('<a href="#" id="delete">[Delete]</a>)').on("click", deleteRow));

        $(row).append($(linksCol));
        $(countriesTable).append(row);
        changeLinks();
    }

    function moveUp(){
        let current = $(this).parent().parent();
        let previous = $(current).prev();
        $(current).insertBefore($(previous));
        changeLinks();
    }
    
    function moveDown(){
        let current = $(this).parent().parent();
        let next = $(current).next();
        $(current).insertAfter($(next));
        changeLinks();
    }
    
    function deleteRow() {
        $(this).parent().parent().remove();
        changeLinks();
    }

    function changeLinks(){
        let allRows = $('#countriesTable tr');
        let lastRow = allRows[allRows.length - 1];
        let firstRow = allRows[2];

        $("#up,#down,#delete").css("display", "inline");
        $(firstRow).find("#up").css("display", "none");
        $(lastRow).find("#down").css("display", "none");
    }
}