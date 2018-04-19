function putTheChains(arr){
    let html = arr[0];
    let pattern_p = /<p>(.*?)<\/p>/g;
    let paragraphs = [];

    let match = pattern_p.exec(html);

    while(match){
        paragraphs.push(match[1]);
        match = pattern_p.exec(html);
    }

    let manualText = "";
    for(let p of paragraphs){
        p = p.replace(/[^a-z0-9]+/g, " ").replace(/\s{2, }/g, " ");
        manualText += convertLetters(p);
    }

    console.log(manualText);

    function convertLetters(p){
        let converted = "";

        for(let index = 0; index < p.length; index++){
            let charCode = p.charCodeAt(index);

            if(charCode >= 97 && charCode <= 109){
                charCode += 13;
            }else if(charCode >= 110 && charCode <= 122){
                charCode -= 13;
            }
            converted += String.fromCharCode(charCode);
        }
        return converted;
    }
}

/* Uncomment to test:
putTheChains(["<html><head><title></title></head><body><h1>hello</h1><p>znahny!@#%&&&&****</p><div><button>dsad</button></div><p>grkg^^^^%%%)))([]12</p></body></html>"]);

putTheChains(["<html><head><title></title></head><body><h1>Intro</h1><ul><li>Item01</li><li>Item02</li><li>Item03</li></ul><p>jura qevivat va jrg fyvccrel fabjl</p><div><button>Click me, baby!</button></div><p> pbaqvgvbaf fabj  qpunvaf ner nofbyhgryl rffragvny sbe fnsr unaqyvat nygubhtu fabj punvaf znl ybbx </p><span>This manual is false, do not trust it! The illuminati wrote it down to trick you!</span><p>vagvzvqngvat gur onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc va pbyq jrg</p><p> pbaqvgvbaf guvf vf rnfvre fnvq guna qbar ohg vs lbh chg ba lbhe gverf</p></body>"]);
*/