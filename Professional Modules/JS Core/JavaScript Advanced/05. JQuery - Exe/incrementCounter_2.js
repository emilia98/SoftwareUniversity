function increment(selector){
    let container = $(selector);
    let fragment = document.createDocumentFragment();
    let textarea = $('<textarea>');
    let incrementBtn = $('<button>');
    let addBtn = $('<button>');
    let ul = $('<ul>');

    textarea.val(0);
    textarea.attr("class", "counter");
    textarea.attr("disabled", "disabled");

    ul.attr("class", "results");

    incrementBtn.attr("id", "incrementBtn")
                .attr("class", "btn")
                .text("Increment")
                .click(() => {
                    textarea.val(+(textarea.val()) + 1)
                });

    addBtn.attr("id", "addBtn")
          .attr("class", "btn")
          .text("Add")
          .click(() => {
              ul.append(`<li>${textarea.val()}</li>`)
          });

    $(fragment).append(textarea)
               .append(incrementBtn);
    addBtn.appendTo(fragment);
    ul.appendTo(fragment);

    container.append(fragment);
}