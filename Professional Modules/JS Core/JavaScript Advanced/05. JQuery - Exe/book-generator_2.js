function createBook(selector, title, author, isbn){
    let id = $(selector).children().length + 1;
    let div = $(`<div id="book${id}"></div>`)
                .append(`<p class="title">${title}</p>`)
                .append(`<p class="author">${author}</p>`)
                .append(`<p class="isbn">${isbn}</p>`)
                .append($(`<button>Select</button>`).click(() => {
                        div.css("border", "2px solid blue")}))
                .append($(`<button>Deselect</button>`).click(deselect));

    $(selector).append(div);

    function deselect(){
        $(this).parent().css("border", "none");
    }
}