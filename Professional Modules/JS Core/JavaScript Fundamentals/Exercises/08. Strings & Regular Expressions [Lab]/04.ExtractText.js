function extractText(text){
    let opening = text.indexOf("(");
    let closing = text.indexOf(")");
    let extractedWords = [];

    let subText = text;

    while(opening > -1 && closing > -1){
        subText = subText.substring(opening + 1);
        extractedWords.push(subText.substring(0, closing - opening - 1));
        subText = subText.substring(closing - opening - 1);

        opening = subText.indexOf("(", opening + 1);
        closing = subText.indexOf(")", opening);

    }

    console.log(extractedWords.join(", "));
}

// Uncomment to test:
extractText('Rakiya (Bulgarian brandy) is self-made liquor (alcoholic drink)');
extractText("Rakiya )Bulgarian )brandy) is self-made liquor (alcoholic drink)");
extractText("Rakiya )Bulgarian )brandy) is self-made liquor )alcoholic drink)");
extractText("(Rakiya (***)brandy) is self-made liquor )alcoholic drink)");
