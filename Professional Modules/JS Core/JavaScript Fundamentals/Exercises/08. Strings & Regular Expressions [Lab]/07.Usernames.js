function getUsernames(array){
    let usernames = [];

    for(let email of array){
        let splitEmail = email.split("@");

        let username = "";
        let domainNames = splitEmail[1].split(".");

        //Get the first part of email as main part of username
        username += splitEmail[0];
        // Get all first letters of domain as second part of username
        username += "." + getFirstLettersFromDomains(domainNames);

        usernames.push(username);
    }

    console.log(usernames.join(", "));

    function getFirstLettersFromDomains(domains){
        let result = "";

        for(let domain of domains){
            result += domain[0];
        }

        return result;
    }

}

/* Uncomment to test:
getUsernames(['peshoo@gmail.com', 'todor_43@mail.dir.bg', 'foo@bar.com', 'pesho.pesheeev@mail.dir.bg']);
*/