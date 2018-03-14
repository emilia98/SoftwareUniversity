function extractHyperlinks(arr){
    let text = arr.join("");
    let pattern = /<a\s*[^>]+href\s*=\s*("([^"]*)"|'([^']*)'|([^>\s]*))[^>]*>/g;

    let match = pattern.exec(text);
    while(match){
        if(match[4] !== undefined) {
            console.log(match[4]);
        } else if(match[3] !== undefined) {
            console.log(match[3]);
        } else if(match[2] !== undefined) {
            console.log(match[2]);
        }
        match = pattern.exec(text);
    }
}

/* Uncomment to test:
extractHyperlinks(["<a href=\"http://softuni.bg\" class=\"new\"></a>",
    "<a href=\"/\"  id=\"home\">Home</a>",
    "<a class=\"selected\" href=/courses>Courses</a>",
    "<a href = '/forum' >Forum</a>",
    "<a class=\"href\" onclick=\"go()\" href= \"#\">Forum</a>",
    "<a id=\"js\" href = \"javascript:alert('hi yo')\" class=\"new\">click</a>",
    "<a id='nakov' href = http://www.nakov.com class='new'>nak</a>",
    "<a target = \"_blank\" href=\"#empty\"></a>",
    "<a id=\"href\" target = \"_blank\">href='fake'<img src='http://abv.bg/i.gif' alt='abv'/></a><a href=\"#\">&lt;a href='hello'&gt;</a>",
    "<a href=\"#commented\">commentex hyperlink</a>"]);
extractHyperlinks(["<p>This text has no links</p>"]);
*/
