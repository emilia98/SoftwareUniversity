//DOESN'T WORK 100 % PROPERLY -> doesn't match an opening tag in <p></p>
function putTheChains(arr){
    let html = arr[0];
    // ??? Are There Any Intervals Between <p> ??? -> NO
    // This match the innermost tag, but we don't need this
    // The first opening + the first closing is what we need
    // THIS SHOULD BE NON-GREEDY
    let pattern_p = /<p>([^<]*)<\/p>/g;
    let matches = html.match(pattern_p);
console.log(matches);
    let manualText = "";

    if(matches){
        for(let match of matches){
            // remove tags
            match = match.replace(/<p>/g, "").replace(/<\/p>/g, "");
            // remove the unnecessary symbols
            match = match.replace(/[^a-z0-9]+/g, " ").replace(/\s\s*/g, " ");
            manualText += convertLetters(match);
        }
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

putTheChains(["<p>jura qevivat va jrg fyvccrel!@##$%%^&&&*!@##$%%^&&&* fabjl pbaqvgvbaf fabj !@##$%%^&&&*punvaf ner nofbyhgryl rffragvny sbe<p></p>%%%%%%% fnsr unaqyvat nygubhtu fabj punvaf znl ybbx vagvzvqngvat gur!@##$%%^&&&*onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc!@##$%%^&&&* va pbyq</p>"]);
*/

putTheChains(["<p>jura qevivat va jrg fyvccrel!@##$%%^&&&*!@##$%%^&&&* fabjl pbaqvgvbaf fabj !@##$%%^&&&*punvaf ner nofbyhgryl rffragvny sbe<p></p>%%%%%%% fnsr unaqyvat nygubhtu fabj punvaf znl ybbx vagvzvqngvat gur!@##$%%^&&&*onfvp vqrn vf ernyyl fvzcyr svg gurz bire lbhe gverf qevir sbejneq fybjyl naq gvtugra gurz hc!@##$%%^&&&* va pbyq</p>"])