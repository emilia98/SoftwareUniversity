function repeatIt(count, f){
    for(let i = 1; i <= count; i++){
        f(i);
    }
}

let printStars = function (i) {
    console.log("**".repeat(i));
}

repeatIt(3, printStars);
repeatIt(3, function(x){ console.log(2 * x); });