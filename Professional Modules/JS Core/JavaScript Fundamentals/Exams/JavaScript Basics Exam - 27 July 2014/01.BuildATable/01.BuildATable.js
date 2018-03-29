function buildTable(arr){
    let start = parseInt(arr[0]);
    let end = parseInt(arr[1]);

    let table = "<table>\n";
    table += "<tr><th>Num</th><th>Square</th><th>Fib</th></tr>\n";
    for(let counter = start; counter <= end; counter++){
        table += "<tr>";
        table += `<td>${counter}</td>`;
        table += `<td>${counter * counter}</td>`;
        table += `<td>${isFibonacci(counter)}</td>`;
        table += "</tr>\n";
    }
    table += "</table>";

    console.log(table);

    function isFibonacci(n){
        let res1 = Math.sqrt(5 * n * n - 4);
        let res2 = Math.sqrt(5 * n * n + 4);

        if(parseInt(res1) === res1 || parseInt(res2) === res2){
            return "yes";
        }
        return "no";
    }
}

/* Uncomment to test:
buildTable([2, 6]);
buildTable([55, 56]);
*/