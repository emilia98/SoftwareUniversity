console.log("Before promises...");
let p1 = new Promise(function(resolve, reject){
    setTimeout(() => resolve({name: "Pesho"}), 1000);
});
let p2 = new Promise(function(resolve, reject){
    setTimeout(() => resolve({name: "Gosho"}), 1500);
});
let p3 = new Promise(function(resolve, reject){
    setTimeout(() => resolve({name: "Maria"}), 500);
});

p1.then((data) => console.log(data.name));
p2.then((data) => console.log(data.name));
p3.then((data) => console.log(data.name));

console.log("After promises...");

/*
Asynchronous way -> Execution is parallel -> if two tasks are executing at a time, the execution of the first one doesn't conflict with the execution of the other.
--- Like you're in a restaurant ---
Your order is being prepared while another one is being prepared, too.
 */