function extractText(text){
    let result = [];
    let openingIndex = text.indexOf("(");

    while(openingIndex > -1){
        let closingIndex = text.indexOf(")", openingIndex);

        if(closingIndex === -1){
            break;
        }

        let substr = text.substring(openingIndex + 1, closingIndex);
        result.push(substr);
        openingIndex = text.indexOf("(", closingIndex);
    }

    console.log(result.join(", "));
}

// Uncomment to test:
extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');
extractText("Rakiya )Bulgarian )brandy) is self-made liquor (alcoholic drink)");
extractText("Rakiya )Bulgarian )brandy) is self-made liquor )alcoholic drink)");
extractText("(Rakiya (***)brandy) is self-made liquor )alcoholic drink)");
