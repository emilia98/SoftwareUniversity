function check(x) {
    if(x > 0){
        return "positive";
    }
    else if(x < 0){
        return "negative";
    }
    else if(x == 0){
        return 0;
    }
}

console.log(check(1));
console.log(check(-1));
console.log(check(0));
console.log(check());
console.log(check("hello"));