function search(){
    let searchText = $('#searchText')[0];
    let matchingItems = 0;

    $('#towns').children().each((i, e) => {
        if(e.textContent.includes(searchText.value)){
            e.className = "bold";
            matchingItems++;
        }else{
            e.className = "";
        }
    });

    $('li').css("font-weight", "normal");
    $('.bold').css("font-weight", "bold");

    $("#result").text(`${matchingItems} matches found.`);
}