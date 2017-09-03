function convertCurrencies([arg1, arg2, arg3]){
    let money = parseFloat(arg1);
    let firstCurrency = arg2,
        secondCurrency = arg3;

    //Convert money from first currency to BGN
    if(firstCurrency == "USD"){
        money *= 1.79549;
    }
    else if(firstCurrency == "EUR"){
        money *= 1.95583;
    }
    else if(firstCurrency == "GBP"){
        money *= 2.53405;
    }
    /* We have third case -> firstCurrency == "BGN";
    else{
        money = money;
    }
    */

    //Convert the money from BGN to the second currency
    if(secondCurrency == "USD"){
        money /= 1.79549;
    }
    else if(secondCurrency == "EUR"){
        money /= 1.95583;
    }
    else if(secondCurrency == "GBP"){
        money /= 2.53405;
    }
    /* We have third case -> firstCurrency == "BGN";
     else{
     money = money;
     }
     */
    console.log(`${money.toFixed(2)} ${secondCurrency}`)
}

/* Uncomment to test:
convertCurrencies(["20", "USD", "BGN"]);
convertCurrencies(["100", "BGN", "EUR"]);
convertCurrencies(["12.35", "EUR", "GBP"]);
convertCurrencies(["150.35", "USD", "EUR"]);
    */