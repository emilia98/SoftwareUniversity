function calculateBill(array) {
    let products = [];
    let prices = [];

    for(let index = 0; index < array.length; index++){
        if(index % 2 == 0){
            products.push(array[index]);
        }
        else{
            prices.push(Number(array[index]));
        }
    }

    let totalPrice = 0;
    totalPrice = calculatePrice(prices);

    console.log(`You purchased ${products.join(", ")} for a total sum of ${totalPrice}`);

    function calculatePrice(prices){
        let total = 0;

        for(let price of prices){
            total += price;
        }

        return total;
    }
}

/* Uncomment to test:
calculateBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
calculateBill(['Cola', '1.35', 'Pancakes', '2.88']);
*/