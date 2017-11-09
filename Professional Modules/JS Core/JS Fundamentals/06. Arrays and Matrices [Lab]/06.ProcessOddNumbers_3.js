// Lines from 2 to 4 work correctly only in JUDGE Testing System, but not here.
(array) => array.filter((num, i) => i % 2 != 0).
           map(num => num *= 2).
           reverse().join(" ");


// Modified code to work correctly here
// DOESN'T WORK IN JUDGE TESTING SYSTEM
let f = function(arr){
    console.log(arr.filter((num, i) => i % 2 != 0).map(num => num *= 2).reverse().join(" "));
}
f([10, 15, 20, 25]);
f([3, 0, 10, 4, 7, 3]);
