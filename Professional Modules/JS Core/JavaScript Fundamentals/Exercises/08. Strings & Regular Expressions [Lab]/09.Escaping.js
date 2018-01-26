//We should escape the ampersand first, the other symbols
// because the other escaped symbols contain ampersand as
// html escaping
function escapeHtml(array) {
    let result = "<ul>\n";
    let lessThanPattern = /(\<)/g;//new RegExp("(\\<)","g");
    let greaterThanPattern = /(\>)/g;//new RegExp("(\\<)","g");
    let ampersandPattern = /(\&)/g;//new RegExp("(\\<)","g");
    let doubleQuotePattern = /(\")/g;//new RegExp("(\\<)","g");

    for (let item of array) {

        let lessThanMatches = item.match(lessThanPattern);
        let greaterThanMatches = item.match(greaterThanPattern);
        let ampersandMatches = item.match(ampersandPattern);
        let doubleQuoteMatches = item.match(doubleQuotePattern);

        if(ampersandMatches != null){
            item = matchAllOccurrences(ampersandMatches, item, "&amp;");
        }

        if(lessThanMatches != null){
            item = matchAllOccurrences(lessThanMatches, item, "&lt;");
        }

        if(greaterThanMatches != null){
            item = matchAllOccurrences(greaterThanMatches, item, "&gt;");
        }

        if(doubleQuoteMatches != null){
            item = matchAllOccurrences(doubleQuoteMatches, item, "&quot;");
        }

        result += `  <li>${item}</li>\n`;
    }

    result += "</ul>";
    console.log(result);

    function matchAllOccurrences(matches, str, strToUse) {
        for (let match of matches) {
            str = str.replace(match, strToUse);
        }
        return str;
    }
}

/* Uncomment to test:
escapeHtml(['<b>unescaped text</b>', 'normal text']);
escapeHtml(['<div style=\\"color: red;\\">Hello, Red!</div>', '<table><tr><td>Cell 1</td><td>Cell 2</td><tr>']);
escapeHtml(['<div style=\\"color: red;\\">Hello, &Red!</div>', '<table><tr><td>Cell 1</td><td>Cell 2</td><tr>']);
*/

