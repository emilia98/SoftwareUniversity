function extractText(){
    let extractedText = [];
    $('#items li').each((index, element) => extractedText.push(element.textContent));
    $('#result').text(extractedText.join(", "));
}