function matchDates(arr){
    let pattern = /\b[0-9]{1,2}-[A-Z][a-z]{2}-[0-9]{4}\b/g;

    for(let sentence of arr) {
        let matches = sentence.match(pattern);

        if (matches != null) {
            for (let match of matches) {
                let splitMatch = match.split('-');

                let day = splitMatch[0];
                let month = splitMatch[1];
                let year = splitMatch[2];

                console.log(`${match} (Day: ${day}, Month: ${month}, Year: ${year})`);
            }
        }
    }
}

/* Uncomment to test:
matchDates([ 'I am born on 30-Dec-1994.',
    'This is not date: 512-Jan-1996.', 'My father is born on the 29-Jul-1955.']);
matchDates([ '1-Jan-1999 is a valid date.',
    'So is 01-July-2000.',
    'I am an awful liar, by the way – Ivo, 28-Sep-2016.']);
matchDates([ '01-Jan-1999 is a valid date.',
    'So is 01-July-20001-July-2000.',
    'I am an awful liar, by the way – Ivo, 28-Sep-016.']);
matchDates([ 'I dont know what to test anymore so here are some random dates.',
    '15-May-1996',
    '15-May-1996 11-Sep-2001',
    '21-June-1995',
    '31-February-3000',
    'woops that was invalid...',
    '111-Nov-2332',
    '01-January-0001',
    'What the fuck',
    '11-Sep-2001',
    'One minute of silence!']);
*/