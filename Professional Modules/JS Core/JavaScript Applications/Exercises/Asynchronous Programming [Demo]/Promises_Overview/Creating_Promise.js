console.log("Before promise");
let p = new Promise(function (resolve, reject) {
    setTimeout(() => resolve("Success", 1000));
});
console.log("After promise");

p.then((data) => console.log(data))
 .catch((reason) => console.log(reason));

 /*
 then() -> If the state of the promise changes to resolved, we will send the data to then() and then() will do something
 ------------------------------------------------------
 catch() -> If the state of the promise changes to rejected, we will send the reason/error to catch()
 */