function grabAndGo(str, k) {
    let array = str.split(' ').map(el => parseInt(el));
    let num = parseInt(k);

    let lastIndex = array.lastIndexOf(num);
    let sum = 0;

    if (lastIndex == -1) {
        console.log("No occurrences were found!");
    } else {
        let sum = array.slice(0, lastIndex).reduce((a, b) => a + b);
        console.log(sum);
    }
}

grabAndGo("1 3 5 7 12 2 3 5 12", 3);
grabAndGo("1 2 3 4 5 6 7 8 9 10", 20);