function wikiParser(selector){
    let text = $(selector).text();

    let h3_pattern = /===([^=]+)===/g;
    let h2_pattern = /==([^=]+)==/g;
    let h1_pattern = /=([^=]+)=/g;
    let fullAnchor = /\[\[([^\]\[\|]+)\|([^\]\[\|]+)\]\]/g;
    let anchor = /\[\[([^\]\[]+)\]\]/g;
    let bold_pattern = /'''([^']+)'''/g;
    let italic_pattern = /''([^']+)''/g;

    // fm -> full match   g -> group
    text = text
        .replace(h3_pattern, (fm, g) => { return `<h3>${g}</h3>`})
        .replace(h2_pattern, (fm, g) => { return `<h2>${g}</h2>`})
        .replace(h1_pattern, (fm, g) => { return `<h1>${g}</h1>`})
        .replace(fullAnchor, (fm, g1, g2) => { return `<a href="/wiki/${g1}">${g2}</a>`})
        .replace(anchor, (fm, g) => { return `<a href="/wiki/${g}">${g}</a>`})
        .replace(bold_pattern, (fm, g) => { return `<b>${g}</b>`})
        .replace(italic_pattern, (fm, g) => { return `<i>${g}</i>`});

    $(selector).html(text);
}