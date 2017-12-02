function manipulateArray(str, arr){
    let nums = str.split(' ').map(el => parseInt(el));
    let commands = arr.slice(0, arr.length);

    let cnt = 0;
    while(commands[cnt] != "print"){
        let splitCommand = commands[cnt].split(' ');

        if(splitCommand[0] == "add"){
            let index = parseInt(splitCommand[1]);
            let element = parseInt(splitCommand[2]);
            let elementData = [index, element];
            nums = operateWithElements(splitCommand[0], nums, elementData);
        }
        else if(splitCommand[0] == "addMany"){
            let index = parseInt(splitCommand[1]);
            let elements = splitCommand.slice(2, splitCommand.length).map(el => parseInt(el));
            let elementData = [index, elements];
            nums = operateWithElements(splitCommand[0], nums, elementData);
        }
        else if(splitCommand[0] == "contains"){
            let element = parseInt(splitCommand[1]);
            console.log(isContained(nums, element));
        }
        else if(splitCommand[0] == "remove"){
            let index = parseInt(splitCommand[1]);
            let elementData = [index];
            nums = operateWithElements(splitCommand[0], nums, elementData);
        }
        else if(splitCommand[0] == "shift"){
            let positions = parseInt(splitCommand[1]);
            positions = positions % nums.length;
            nums = shiftElements(nums, positions);
        }
        else if(splitCommand[0] == "sumPairs"){
            nums = sumPairs(nums);
        }
        cnt++;
    }

    console.log(`[${nums.join(", ")}]`);

    function operateWithElements(command, nums, elementData){
        let newNums = [];
        let index = elementData[0];

        newNums = addFirstPart(nums, index);

        if(command == "remove"){
            newNums = addSecondPart(nums, newNums, index + 1);

        }else{
            if(command == "add"){
                let element = elementData[1];

                newNums.push(element);
            }else{
                let elements = elementData[1];

                for(let element of elements){
                    newNums.push(element);
                }
            }
            newNums = addSecondPart(nums, newNums, index);
        }
        return newNums;
    }

    function addFirstPart(nums, index){
        let newList = [];

        for(let cnt = 0; cnt < index; cnt++){
            newList.push(nums[cnt]);
        }
        return newList;
    }

    function addSecondPart(nums, newNums, index){
        for(let cnt = index; cnt < nums.length; cnt++){
            newNums.push(nums[cnt]);
        }
        return newNums;
    }

    function isContained(nums, element){
        for(let index in nums){
            if(element === nums[index]){
                return index;
            }
        }
        return -1;
    }

    function shiftElements(nums, pos){
        let shiftedList = nums.slice(0, nums.length);

        for(let cnt = 1; cnt <= pos; cnt++){
            let element = shiftedList.shift();
            shiftedList.push(element);
        }
        return shiftedList;
    }

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
}

manipulateArray("1 2 4 5 6 7", ["add 1 8", "contains 1", "contains -3", "print"]);
manipulateArray("1 2 3 4 5", ["addMany 5 9 8 7 6 5", "contains 15", "remove 3", "shift 1","print"]);
manipulateArray("2 2 4 2 4", ["add 1 4", "sumPairs", "print"]);
manipulateArray("1 2 1 2 1 2 1 2 1 2 1 2", ["sumPairs", "sumPairs", "addMany 0 -1 -2 -3", "print"]);










