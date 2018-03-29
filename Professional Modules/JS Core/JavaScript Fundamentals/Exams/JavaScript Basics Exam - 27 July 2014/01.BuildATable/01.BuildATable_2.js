function buildTable(arr){
    let start = +arr[0];
    let end = +arr[1];

    let table = "<table>\n";
    table += "<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n";
    for(let counter = start; counter <= end; counter++){
        table += `<tr><td>${counter}</td><td>${Math.pow(counter, 2)}</td><td>${isFibonacci(counter)}</td></tr>\n`;
    }
    table += "</table>";

    return table;

    function isFibonacci(n){
        let f1 = 1;
        let f2 = 1;
        let f3;

        if(n === 1){
            return "yes";
        }

        while(true){
            f3 = f1 + f2;
            if(f3 >= n){
                return f3 === n ? "yes" :  "no";
            }
            f1 = f2;
            f2 = f3;
        }
    }
}

/* Uncomment to test:
console.log(buildTable([2, 6]));
console.log(buildTable([55, 56]));
console.log(buildTable(["1", "8"]));
*/