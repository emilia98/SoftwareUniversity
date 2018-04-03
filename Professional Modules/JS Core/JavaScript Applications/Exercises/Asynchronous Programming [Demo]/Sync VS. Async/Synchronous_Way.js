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

Promise.all([p1, p2, p3]).then((results) => {
    console.log(results.map(r => r.name).join("\n"));
});

console.log("After promises...");

/*
Synchronous way -> Execution is not parallel -> if two tasks are not executing at a time. The execution of the second task waits until the execution of the first one finishes.
--- Like you're waiting on a queue ---
You could buy a ticket after the person before you has left.
 */