let f = counter => ++counter;
console.log(f(5));

console.log((counter => ++counter)(5));

(() => console.log("Hello, JavaScript!"))();