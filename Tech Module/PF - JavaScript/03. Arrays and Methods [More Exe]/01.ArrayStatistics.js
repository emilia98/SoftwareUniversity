function calculateStatistics(str){
    let array = str.split(' ').map(el => parseInt(el));
    let max = Number.MIN_SAFE_INTEGER;
    let min = Number.MAX_SAFE_INTEGER;
    let sum = 0;

    for(let number of array){
        if(number > max){
            max = number;
        }

        if(number < min){
            min = number;
        }

        sum += number;
    }

    let avg = sum / array.length;

    console.log(`Min = ${min}`);
    console.log(`Max = ${max}`);
    console.log(`Sum = ${sum}`);
    console.log(`Average = ${avg}`);
}

calculateStatistics("2 3 4 5 6 1");
calculateStatistics("-1 200 124123 -400 -124214");
