function findTimeAfter15Minutes([arg1, arg2]){
    let hour = parseInt(arg1);
    let minutes = parseInt(arg2);

    let totalMinutes = hour * 60 + minutes + 15;

    hour = parseInt(totalMinutes / 60);
    minutes = totalMinutes % 60;

    if(hour == 24){
        hour -= 24;
    }

    if(minutes < 10){
        minutes = "0" + minutes;
    }
    console.log(`${hour}:${minutes}`);
}

/* Uncomment to test:
findTimeAfter15Minutes(["1", "46"]);
findTimeAfter15Minutes(["0", "01"]);
findTimeAfter15Minutes(["23", "59"]);
findTimeAfter15Minutes(["11", "08"]);
findTimeAfter15Minutes(["12", "49"]);
    */