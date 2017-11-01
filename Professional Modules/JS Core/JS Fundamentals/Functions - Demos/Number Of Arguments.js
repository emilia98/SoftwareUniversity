function sum(){
    /*arguments -> returns a dictionary with keys (indexes)
       and values (the respective values of given parameters)
    * */
    console.log(arguments);

    console.log("Argument count: " + arguments.length);

    let sum = 0;
    for(let arg of arguments){
        sum += arg;
    }
    console.log("Sum = " + sum);
}

sum();
sum(5, 3);
sum(4, 2, 3);