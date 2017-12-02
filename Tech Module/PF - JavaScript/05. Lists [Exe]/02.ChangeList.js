function changeList(str, arr){
    let nums = str.split(' ').map(el => parseInt(el));
    let commands = arr.slice(0, arr.length);

    let index = 0;
    let command = commands[index];

    while(true){

        if(command == "Odd"){
            console.log(nums.filter(num =>
                                    num % 2 == 1).join(" "));
            break;
        }
        if(command == "Even"){
            console.log(nums.filter(num =>
                                    num % 2 == 0).join(" "));
            break;
        }

        let splitCommand = command.split(' ');

        if(splitCommand[0] == "Delete"){
            let element = parseInt(splitCommand[1]);

            for(let index = 0; index < nums.length; index++){
                if(element === nums[index]){
                    nums.splice(index, 1);
                    index--;
                }
            }
        }else if(splitCommand[0] == "Insert"){
            let element = parseInt(splitCommand[1]);
            let position = parseInt(splitCommand[2]);

            nums.splice(position, 0, element);
        }
        index++;
        command = commands[index];
    }
}

changeList("1 2 3 4 5 5 5 6", ["Delete 5", "Insert 10 1", "Delete 5","Odd"]);
changeList("20 12 4 319 21 31234 2 41 23 4", ["Insert 50 2", "Insert 50 5", "Delete 4", "Even"]);
changeList("1 1 1 2", ["Delete 1", "Delete 2", "Odd"]);











