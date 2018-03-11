function increment(selector){
    $(selector)
        .append('<textarea class="counter" disabled="disabled">0</textarea>')
        .append('<button class="btn" id="incrementBtn">Increment</button>')
        .append('<button class="btn" id="addBtn">Add</button>')
        .append("<ul class='results'></ul>");

    let incrementBtn = $('#incrementBtn').click(increment);
    let addBtn = $('#addBtn').click(add);
    let counterArea = $('textarea.counter')[0];
    let counter = parseInt($(counterArea).val());

    function increment(){
        counter++;
        $(counterArea).val(counter);
    }

    function add(){
        $('ul.results').append(`<li>${counter}</li>`);
   }
}