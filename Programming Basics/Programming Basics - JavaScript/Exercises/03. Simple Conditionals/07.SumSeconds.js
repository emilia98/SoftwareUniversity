function sumSeconds([arg1, arg2, arg3]){
    let comp1 = parseInt(arg1);
    let comp2 = parseInt(arg2);
    let comp3 = parseInt(arg3);

    let sum = comp1 + comp2 + comp3;
    let minutes = parseInt(sum / 60);
    let seconds = sum % 60;

    minutes = minutes.toString();
    seconds = seconds.toString();

    if(seconds < 10){
        seconds = "0" + seconds;
    }
    console.log(`${minutes}:${seconds}`);
}

/* Uncomment to test:
sumSeconds(["35", "45", "44"]);
sumSeconds(["22", "7", "34"]);
sumSeconds(["50", "50", "49"]);
sumSeconds(["14", "12", "10"]);
    */