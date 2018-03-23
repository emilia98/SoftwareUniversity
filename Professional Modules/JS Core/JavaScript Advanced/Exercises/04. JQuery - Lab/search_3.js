function search(){
    let searchText = $('#searchText').val();
    let matches = 0;

    $("#towns li").each((i, el) => {
        if(el.textContent.includes(searchText)){
            $(el).css("font-weight", "bold");
            matches++;
        }else{
            $(el).css("font-weight", "normal");
        }
    });

    $("#result").text(`${matches} matches found.`);
}