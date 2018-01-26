function filterForm(username, email, number, arr){
    let usernamePattern = new RegExp('(<![A-Za-z]+!>)', 'g');
    let emailPattern = new RegExp('(<@[A-Za-z]+@>)', 'g');
    let numberPattern = new RegExp('(<\\+[A-Za-z]+\\+>)', 'g');

    for (let sentence of arr) {
        let usernameMatches = sentence.match(usernamePattern);
        let emailMatches = sentence.match(emailPattern);
        let numberMatches = sentence.match(numberPattern);

        if(usernameMatches != null){
            sentence = matchAllOccurrences(usernameMatches, sentence, username);
        }

        if(emailMatches != null){
            sentence = matchAllOccurrences(emailMatches, sentence, email);
        }

        if(numberMatches != null){
            sentence = matchAllOccurrences(numberMatches, sentence, number);
        }

        console.log(sentence);
    }

    function matchAllOccurrences(matches, sentence, dataToUse){
        for (let match of matches) {
            sentence = sentence.replace(match, dataToUse);
        }
        return sentence;
    }
}

/* Uncomment to test:
filterForm('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+>. Would you like to change that? (Y/N)']
);
filterForm('Pesho',
    'pesho@softuni.bg',
    '90-60-90',
    ['Hello, <!username!>!',
        'Welcome to your Personal profile.',
        'Here you can modify your profile freely.',
        'Your current username is: <!fdsfs!> <!fdsfs!>. Would you like to change that? (Y/N)',
        'Your current email is: <@DasEmail@> <@DasEmail@>. Would you like to change that? (Y/N)',
        'Your current phone number is: <+number+> <+NuMber+>. Would you like to change that? (Y/N)']
);
*/