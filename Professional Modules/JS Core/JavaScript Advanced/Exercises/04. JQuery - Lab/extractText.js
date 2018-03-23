function extractText(){
   let items = $('#items').children();
   let result = $('#result');

   let extractedText = [];
   for(let item of items){
       extractedText.push(item.textContent);
   }
   result.text(extractedText.join(", "));
}