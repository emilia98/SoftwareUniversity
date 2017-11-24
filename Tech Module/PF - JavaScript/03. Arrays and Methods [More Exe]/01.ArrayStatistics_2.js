function calculateStatistics(str){
    let array = str.split(' ').map(el => parseInt(el));
    array.sort((a,b) => b - a);

    let min = array[array.length - 1];
    let max = array[0];
    let sum = array.reduce( (a, b) => a + b);
    let avg = sum / array.length;

    console.log(`Min = ${min}`);
    console.log(`Max = ${max}`);
    console.log(`Sum = ${sum}`);
    console.log(`Average = ${avg}`);
}

calculateStatistics("2 3 4 5 6 1");
calculateStatistics("-1 200 124123 -400 -124214");
