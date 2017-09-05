function calculateBonusScore([arg1]){
    let score = parseInt(arg1);
    let bonusScore = 0;

    if(score <= 100){
        bonusScore += 5;
    }
    else if(score <= 1000){
        bonusScore = 0.2 * score;
    }
    else{
        bonusScore = 0.1 * score;
    }

    if(score % 2 == 0){
        bonusScore += 1;
    }
    else if(score % 10 == 5){
        bonusScore += 2;
    }
    score += bonusScore;

    console.log(bonusScore);
    console.log(score);
}

/* Uncomment to test:
calculateBonusScore(["20"]);
calculateBonusScore(["175"]);
calculateBonusScore(["2703"]);
calculateBonusScore(["15875"]);
    */