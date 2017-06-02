function printSquare([arg1]){
    let n = Number(arg1);
    let row = "";
    let intervals;

    for(let i = 1; i <= n; i++){
           row = "";
           if(i == 1 || i == n){
                row = "*".repeat(n);
           }else{
                row +=  "*";
                intervals = " ".repeat(n - 2);
                row += intervals + "*";
           }
           console.log(row);
    }
}

printSquare(["3"]);
printSquare(["4"]);
printSquare(["5"]);