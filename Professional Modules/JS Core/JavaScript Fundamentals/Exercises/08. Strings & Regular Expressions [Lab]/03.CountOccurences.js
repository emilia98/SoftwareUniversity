function countOccurrences(str, text){
    let counter = 0;
    let size = str.length;

    for(let index = 0; index <= text.length - size; index++){
        let subText = text.substr(index, size);

        if(subText == str){
            counter++;
        }
    }

    console.log(counter);
}

/* Uncomment to test:
countOccurrences('the', 'The quick brown fox jumps over the lay dog.');
countOccurrences('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.');
countOccurrences('aa', 'aaaaa');
*/
