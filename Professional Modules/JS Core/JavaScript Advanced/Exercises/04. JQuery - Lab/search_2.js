function search(){
    let pattern = $("#searchText").val();
    let itemsMatching = $(`#towns li:contains(${pattern})`);
    itemsMatching.css("font-weight", "bold");

    let itemsNotMatching = $(`#towns li:not(:contains(${pattern}))`).css("font-weight", "normal");
    $("#result").text(`${itemsMatching.length} matches found.`);
}