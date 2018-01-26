function countOccurrences(str, text){
    let pattern = new RegExp(str);
    let counter = 0;
    let index = 0;

    while(true){
        let substr = text.substr(index);
        text = substr;

        let match = text.search(pattern);

        if(match === -1){
            break;
        }

        counter++;
        index = match + 1;
    }
    console.log(counter);
}

/* Uncomment to test:
countOccurrences('the', 'The quick brown fox jumps over the lay dog.');
countOccurrences('ma', 'Marine mammal training is the training and caring for marine life such as, dolphins, killer whales, sea lions, walruses, and other marine mammals. It is also a duty of the trainer to do mental and physical exercises to keep the animal healthy and happy.');
countOccurrences('aa', 'aaaaa');
countOccurrences('bb', 'aaaaabbbabb');
*/
