function manipulateArray(str, arr){
    let nums = str.split(' ').map(el => parseInt(el));
    let commands = arr.slice(0, arr.length);

    let cnt = 0;
    while(commands[cnt] != "print"){
        let splitCommand = commands[cnt].split(' ');

        if(splitCommand[0] == "add"){
            let index = parseInt(splitCommand[1]);
            let element = parseInt(splitCommand[2]);
            nums.splice(index, 0, element);

        }else if(splitCommand[0] == "addMany"){
            let index = parseInt(splitCommand[1]);
            let elements = splitCommand.slice(2, splitCommand.length).map(el => parseInt(el));
            for(let element of elements){
                nums.splice(index, 0, element);
                index++;
            }
        }else if(splitCommand[0] == "contains"){
            let element = parseInt(splitCommand[1]);
            console.log(nums.indexOf(element));
        }else if(splitCommand[0] == "remove"){
            let index = parseInt(splitCommand[1]);
            nums.splice(index, 1);
        }else if(splitCommand[0] == "shift"){
            let positions = parseInt(splitCommand[1]);
            positions = positions % nums.length;
            nums = shiftElements(nums, positions);
        }else if(splitCommand[0] == "sumPairs"){
            nums = sumPairs(nums);
        }
        cnt++;
    }

    console.log(`[${nums.join(", ")}]`);

    function sumPairs(nums){
        let summedNums = [];
        if(nums.length % 2 == 1){
            nums.push(0);
        }
        for(let index = 0; index < nums.length; index += 2){
            summedNums.push(nums[index] + nums[index + 1]);
        }
        return summedNums;
    }

    function shiftElements(nums, pos){
        let shiftedList = nums.slice(0, nums.length);
        for(let cnt = 1; cnt <= pos; cnt++){
            let element = shiftedList.shift();
            shiftedList.push(element);
        }
        return shiftedList;
    }
}

manipulateArray("1 2 4 5 6 7", ["add 1 8", "contains 1", "contains -3", "print"]);
manipulateArray("1 2 3 4 5", ["addMany 5 9 8 7 6 5", "contains 15", "remove 3", "shift 1","print"]);
manipulateArray("2 2 4 2 4", ["add 1 4", "sumPairs", "print"]);
manipulateArray("1 2 1 2 1 2 1 2 1 2 1 2", ["sumPairs", "sumPairs", "addMany 0 -1 -2 -3", "print"]);










