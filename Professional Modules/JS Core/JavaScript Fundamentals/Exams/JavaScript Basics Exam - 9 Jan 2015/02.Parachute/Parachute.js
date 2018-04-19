function determineParachuteJump(arr){
    let [initX, initY] = findJumper(arr);
    let windPattern = /(<+)|(>+)/g;
    let matrix = [];
    arr.forEach(r => matrix.push(r.split("")));
    let startRow = initY;

    for(let line = startRow + 1; line < arr.length; line++){
        let moveLeft = 0;
        let moveRight = 0;
        let match = windPattern.exec(arr[line]);

        while(match){
            if(match[0].indexOf("<") > -1){
                moveLeft += match[0].length;
            }else{
                moveRight += match[0].length;
            }
            match = windPattern.exec(arr[line]);
        }

        // ??? COULD BE MOVED OUT OF THE MATRIX ??? -> NO
        if(moveLeft > moveRight){
            initX -= (moveLeft - moveRight);
        }else{
            initX += (moveRight - moveLeft);
        }
        initY++;

        if(hasEnd(initX, initY)){
            break;
        }

        /* Used to visualize the movement of the parachuter
        if(initY < arr.length){
            matrix[initY][initX] = 'o';
        }
        */
    }

    /* Again, final visualization of the movement of the parachuter
    matrix.forEach(el => console.log(el.join("")))
    */

    function findJumper(arr){
        for(let row = 0; row < arr.length; row++){
            let indexOfJumper = arr[row].indexOf('o');

            if(indexOfJumper > -1){
                return [indexOfJumper,row];
            }
        }
        return;
    }

    function hasEnd(x, y){
        if(matrix[y][x] === "_"){
            printOutput("Landed on the ground like a boss!", x, y);
            return true;
        } else if(matrix[y][x] === "~"){
            printOutput("Drowned in the water like a cat!", x, y);
            return true;
        }else if(/[|\/\\]/.test(matrix[y][x])){
            printOutput("Got smacked on the rock like a dog!", x, y);
            return true;
        }
        return false;
    }

    function printOutput(msg, x, y){
        console.log(msg);
        console.log(`${y} ${x}`);
    }
}

/* Uncomment to test:
determineParachuteJump([
    "--o----------------------",
    ">------------------------",
    ">------------------------",
    ">-----------------/\\-----",
    "-----------------/--\\----",
    ">---------/\\----/----\\---",
    "---------/--\\--/------\\--",
    "<-------/----\\/--------\\-",
    "\\------/----------------\\",
    "-\\____/------------------",
]);

determineParachuteJump([
    "-------------o-<<--------",
    "-------->>>>>------------",
    "---------------->-<---<--",
    "------<<<<<-------/\\--<--",
    "--------------<--/-<\\----",
    ">>--------/\\----/<-<-\\---",
    "---------/<-\\--/------\\--",
    "<-------/----\\/--------\\-",
    "\\------/--------------<-\\",
    "-\\___~/------<-----------",
]);
*/