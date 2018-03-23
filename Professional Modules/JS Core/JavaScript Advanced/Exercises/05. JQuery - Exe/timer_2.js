function timer(){
    let hours = $('#hours');
    let minutes = $('#minutes');
    let seconds = $('#seconds');
    let tickTack = null;
    let totalSeconds = 0;
    let totalMinutes = 0;
    let totalHours = 0;

    $('#start-timer').on("click", start);
    $('#stop-timer').on("click", stop);

    function start() {
        if(tickTack === null){
            tickTack = setInterval(increment, 1000);
        }
    }

    function stop(){
        clearInterval(tickTack);
        tickTack = null;
    }

    function increment() {
        totalSeconds++;

        if(totalSeconds >= 60){
            totalSeconds = 0;
            totalMinutes++;
            if(totalMinutes >= 60){
                totalHours++;
                hours.text(("0" + totalHours).slice(-2));
                totalMinutes = 0;
            }
            minutes.text(("0" + totalMinutes).slice(-2));
        }

        seconds.text(("0" + totalSeconds).slice(-2));
    }
}