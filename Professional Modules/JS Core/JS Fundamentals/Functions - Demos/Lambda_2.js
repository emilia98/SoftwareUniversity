let array = [10, 20, 30, 40, 50];
//forEach
array.forEach(e => console.log(e));

//filter
console.log(array.filter(e => (e >= 30)));

// sum two numbers
let sum = ((a, b) => a + b);
console.log(sum(2, 3));

array = [50, 12, 35, 54, -5, 0];
//sort in decreasing
console.log(array.sort((a,b) => b >= a));
//sort in increasing
console.log(array.sort((a,b) => a >= b));