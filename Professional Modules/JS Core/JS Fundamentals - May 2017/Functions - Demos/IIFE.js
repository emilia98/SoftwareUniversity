// Immediately-Invoked Function Expression (IIFE)
(function(count){
    for(let i = 1; i <= count; i++){
        console.log('+'.repeat(i));
    }
})(4);

/* ---------------------------------- */
let f = (function(){
    let x = 0;
    return function () {
        console.log(++x);
    }
})();
f();
f();
f();
f();