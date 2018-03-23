function wikiParser(selector){
    let text = $(selector).text().split('\n').filter(el => el !== "");
    let newText = [];

    let h3_pattern = new RegExp("[=]{3}([^\=]+)[=]{3}", "g");
    let h2_pattern = new RegExp("[=]{2}([^\=]+)[=]{2}", "g");
    let h1_pattern = new RegExp("[=]{1}([^\=]+)[=]{1}", "g");
    let boldItalic_pattern = /[\']{3}([^\']+)[\']{3}|[\']{2}([^\']+)[\']{2}/g;
    let anchor_pattern = /\[\[([^\]\[]+)\]\]/g;

    for(let sentence of text){
        sentence = sentence
            .replace(h3_pattern, "<h3>$1</h3>")
            .replace(h2_pattern, "<h2>$1</h2>")
            .replace(h1_pattern, "<h1>$1</h1>")
            .replace(
                boldItalic_pattern,
                function(fg, g1, g2) {
                    if(g1 === undefined){
                        return `<i>${g2}</i>`
                    }
                    if(g2 === undefined){
                        return `<b>${g1}</b>`;
                    }
                })
            .replace(anchor_pattern, function(fg, g) {
                let match = g.split('|');

                if(match.length === 1){
                    let link = match[0];
                    return `<a href="/wiki/${link}">${link}</a>`;
                }

                if(match.length === 2){
                    let link = match[0];
                    let text = match[1];
                    return `<a href="/wiki/${link}">${text}</a>`;
                }
            });

        newText.push(sentence);
    }
    $(selector).html(newText.join('\n'));
}
