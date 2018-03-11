function createBook(selector, title, author, isbn){
    let id = $(selector).children().length + 1;

    let div = $('<div>');
    div.attr("id", `book${id}`);

    let title_p = $(`<p>${title}</p>`);
    let author_p = $(`<p>${author}</p>`);
    let isbn_p = $(`<p>${isbn}</p>`);
    title_p.attr('class', "title");
    author_p.attr('class', "author");
    isbn_p.attr('class', "isbn");

    let select = $('<button>Select</button>');
    let deselect = $('<button>Deselect</button>');

    select.click(() => {
        div.css("border", "2px solid blue");
    });

    deselect.click(() => {
        div.css("border", "none");
    });

    div.append(title_p).append(author_p).append(isbn_p).append(select).append(deselect);
    $(selector).append(div);
}