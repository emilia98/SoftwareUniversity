function printName(firstName, lastName){
    let name = firstName;

    if(lastName != undefined){
        name += " " + lastName;
    }
    console.log(name);
}

printName("Maria");
printName("Pesho", "Ivanov");

/*
Unlike C#, C++ and Java, JavaScript doesn't support
function overloading. Here we can have 3 function parameters,
but to call this function with 2 or 4 parameters.
It's not an error.
 */