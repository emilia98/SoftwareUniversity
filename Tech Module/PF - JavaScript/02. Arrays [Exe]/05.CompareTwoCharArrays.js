function compareCharArrays(str1, str2){
    let array1 = str1.split(' ');
    let array2 = str2.split(' ');
    let size1 = array1.length;
    let size2 = array2.length;

    if(size1 < size2){
        printArray(array1, array2);
    }
    else if(size2 < size1){
        printArray(array2, array1);
    }
    else{
        let hasPrinted = false;

        for(let index = 0; index < size1; index++){
            if(array1[index] < array2[index]){
                printArray(array1, array2);
                hasPrinted = true;
                break;
            }
            else if(array1[index] > array2[index]){
                printArray(array2, array1);
                hasPrinted = true;
                break;
            }
        }

        if(!hasPrinted){
            printArray(array1, array2);
        }
    }

    function printArray(arr1, arr2){
        console.log(arr1.join(''));
        console.log(arr2.join(''));
    }
}

compareCharArrays("a b c", "d e f");
compareCharArrays("p e t e r", "a n n i e");
compareCharArrays("a n n i e", "a n");
compareCharArrays("a b", "a b");
