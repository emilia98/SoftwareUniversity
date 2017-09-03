function calculateIncomesInEuro([arg1, arg2, arg3, arg4]){
    let vegetablesKiloPrice = parseFloat(arg1);
    let fruitsKiloPrice = parseFloat(arg2);
    let vegetablesWeight = parseInt(arg3);
    let fruitsWeight = parseInt(arg4);

    let vegetablesTotalPrice = vegetablesKiloPrice * vegetablesWeight;
    let fruitsTotalPrice = fruitsKiloPrice * fruitsWeight;
    let totalPriceInLeva = vegetablesTotalPrice + fruitsTotalPrice;

    let totalPriceInEuro = totalPriceInLeva / 1.94;
    console.log(totalPriceInEuro.toFixed(2));
}

/* Uncomment to test:
calculateIncomesInEuro(["0.194", "19.4","10", "10"]);
calculateIncomesInEuro(["1.5", "2.5","10", "10"]);
    */