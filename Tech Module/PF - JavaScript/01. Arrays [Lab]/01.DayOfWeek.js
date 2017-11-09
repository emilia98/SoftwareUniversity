function getDayOfWeekWithWords(n){
    let day = Number(n);

    let daysAsWords = ["Monday", "Tuesday", "Wednesday", "Thursday",
                       "Friday", "Saturday", "Sunday"];

    if( (day >= 1 && day <= 7) && (parseInt(day) == day)){
        console.log(daysAsWords[day - 1]);
    }
    else{
        console.log("Invalid Day!");
    }
}

getDayOfWeekWithWords(1);
getDayOfWeekWithWords(2);
getDayOfWeekWithWords(7);
getDayOfWeekWithWords(0);
getDayOfWeekWithWords(4.5);