function printMostFrequentNumber(str){
    let array = str.split(' ').map(Number);
    let numbers = new Array(array.length);
    let countTimes = new Array(array.length);

    let cnt = 0;
    for(let index = 0; index < array.length; index++){
        let indexOfCurrent = numbers.indexOf(array[index]);

        if(indexOfCurrent == -1){
            numbers[cnt] = array[index];
            countTimes[cnt] = 1;
            cnt++;
        }
        else{
            countTimes[indexOfCurrent] += 1;
        }
    }

    let timesOfMostFrequent = countTimes[0];
    let mostFrequentIndex = 0;

    for(let index = 1; index < countTimes.length; index++){
        if(timesOfMostFrequent  < countTimes[index]){
            timesOfMostFrequent  = countTimes[index];
            mostFrequentIndex = index;
        }
    }

    console.log(numbers[mostFrequentIndex]);

}

printMostFrequentNumber("4 1 1 4 2 3 4 4 1 2 4 9 3");
printMostFrequentNumber("2 2 2 2 1 2 2 2");
printMostFrequentNumber("7 7 7 0 2 2 2 0 10 10 10");
printMostFrequentNumber("7 7 7 0 2 2 2 0 10 10 10 2");
printMostFrequentNumber("0 8");