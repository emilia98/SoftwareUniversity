// If we use \w -> it will match underscores, but it SHOULDN'T
function validateEmail(str){
    let email = str;

    let pattern = new RegExp(/([A-Za-z0-9]+)@([a-z]+)\.([a-z]+)/);
    let match = email.match(pattern);

    let message = "Valid";

    if(match == null || match[0] !== email){
        message = "Invalid";
    }

    console.log(message);
}

/* Uncomment to test:
validateEmail("valid@email.bg");
validateEmail("invalid@emai1.bg");
validateEmail("valid70@email.bg");
validateEmail("valid70@email.bg.com");
*/
