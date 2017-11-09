function condenseNumbers(input){
    let array = input.split(' ').map(el => parseInt(el));
    let result = array[0];
    let size = array.length;

    while (size != 1)
    {
        for (let index = 0; index < size - 1; index++)
        {
            array[index] = array[index] + array[index + 1];
        }
        size--;

        if (size == 1)
        {
            result = array[0];
        }
    }
    console.log(result);
}

condenseNumbers("2 10 3");
condenseNumbers("5 0 4 1 2");
condenseNumbers("1");