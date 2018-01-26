function extractText(){
    var regex = new RegExp("(.*) (.*) ([0-9]+)");
    var regexGroups = { FirstName: 1, LastName: 2, Age: 3 };

    var m = regex.exec("John Smith 78798");
    var f = m[regexGroups.FirstName];

    console.log();
    f = m[regexGroups.Age];
    console.log(f);
}

/* Uncomment to test:
extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');
extractText("Rakiya )Bulgarian )brandy) is self-made liquor (alcoholic drink)");
extractText("Rakiya )Bulgarian )brandy) is self-made liquor )alcoholic drink)");
extractText("(Rakiya (***)brandy) is self-made liquor )alcoholic drink)");
*/
//extractText("")
extractText();