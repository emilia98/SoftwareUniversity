function validateEmail(email){
    let pattern = new RegExp(/^[A-Za-z0-9]+@[a-z]+(\.[a-z]+){1}$/);
    return pattern.test(email) ? 'Valid' : 'Invalid';
}

/* Uncomment to test:
console.log(validateEmail("valid@email.bg"));
console.log(validateEmail("invalid@emai1.bg"));
console.log(validateEmail("valid70@email.bg"));
console.log(validateEmail("valid70@email.bg.com"));
*/

