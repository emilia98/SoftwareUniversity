function printTemplate(array){
    let result = "";

    result += "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n" +
        "<quiz>\n";
    for(let index = 0; index < array.length; index += 2){
        let question = array[index];
        let answer = array[index + 1];

        result += getQuestionAndAnswer(question, answer);
    }

    result += "</quiz>";
    console.log(result);

    function getQuestionAndAnswer(question, answer){
        let value = "";

        value =`  <question>\n    ${question}\n  </question>\n`;
        value += `  <answer>\n    ${answer}\n  </answer>\n`;
        return value;
    }
}

/* Uncomment to test:
printTemplate(["Who was the forty-second president of the U.S.A.?",
    "William Jefferson Clinton"]);
printTemplate(["Dry ice is a frozen form of which gas?", "Carbon Dioxide",
    "What is the brightest star in the night sky?", "Sirius"]);
    */