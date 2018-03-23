function attachEvents(){
    let links = $('.button').click((event) => {
        $(".selected").removeClass("selected");
        $(event.target).addClass("selected");
    });
}