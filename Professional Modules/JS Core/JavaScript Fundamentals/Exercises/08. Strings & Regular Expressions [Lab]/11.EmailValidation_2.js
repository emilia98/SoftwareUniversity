function validateEmail(str){
    let email = str;

    let splitEmail = email.split("@");

    if(splitEmail.length < 2){
        console.log("Invalid");
        return;
    }

    let name = splitEmail[0];

    for(let index = 0; index < name.length; index++){
        let charCode = name.charCodeAt(index);

        if(  charCode < 48 || charCode > 122 ||
            (charCode > 57 && charCode < 65) ||
            (charCode > 90 && charCode < 97)){
            console.log("Invalid");
            return;
        }
    }

    let domain = splitEmail[1];
    let splitDomain = domain.split(".");

    if(splitDomain.length !== 2){
        console.log("Invalid");
        return;
    }

    if(isDomainValid(splitDomain[0]) && isDomainValid(splitDomain[1])){
        console.log("Valid");
        return;
    }

    console.log("Invalid");

    function isDomainValid(givenDomain){

        for(let index = 0; index < givenDomain.length; index++){
            let charCode = givenDomain.charCodeAt(index);

            if(  !(charCode >= 97 && charCode <= 122) ){
                return false;
            }
        }
        return true;
    }
}

/* Uncomment to test:
validateEmail("valid@email.bg");
validateEmail("invalid@emai1.bg");
validateEmail("valid70@email.bg");
validateEmail("valid70@email.bg.com");
validateEmail("valid70 email.bg.com");
*/

