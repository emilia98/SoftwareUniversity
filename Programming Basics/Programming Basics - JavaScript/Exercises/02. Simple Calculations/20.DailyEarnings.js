function calculateDailyEarnings([arg1, arg2, arg3]){
    let workdays = parseInt(arg1);
    let moneyPerDay = parseFloat(arg2);
    let currencyCourse = parseFloat(arg3);

    let monthSalary = workdays * moneyPerDay;
    let yearlyEarningsInDollars = monthSalary * 12 + monthSalary * 2.5;
    let taxes = yearlyEarningsInDollars * 0.25;
    yearlyEarningsInDollars -= taxes;

    let yearlyEarningsInLeva = yearlyEarningsInDollars * currencyCourse;
    let dailyEarnings = yearlyEarningsInLeva / 365;
    console.log(dailyEarnings.toFixed(2));
}

/* Uncomment to test:
calculateDailyEarnings(["21", "75.00", "1.59"]);
calculateDailyEarnings(["15", "105", "1.71"]);
calculateDailyEarnings(["22", "199.99", "1.50"]);
    */