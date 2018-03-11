function timer(){
    let myTimer = $('#timer');
    let hours = $('#hours');
    let minutes = $('#minutes');
    let seconds = $('#seconds');
    let startTimer = $('#start-timer');
    let stopTimer = $('#stop-timer');

    let tickTack = null;
    let timeInSecs = 0;


    startTimer.click(start);

    stopTimer.click(() => {
        clearInterval(tickTack);
        tickTack = null;
    });

    function start(){
        if(tickTack === null){
            tickTack = setInterval(increment, 1000);
        }
    }

    function increment() {
        timeInSecs++;
        let h = parseInt(timeInSecs / 3600);
        let m = parseInt((timeInSecs / 60) % 60);
        let s = timeInSecs % 60;

        hours.text(("0"+ h).slice(-2));
        minutes.text(("0" + m).slice(-2));
        seconds.text(("0" + s).slice(-2));
    }
}