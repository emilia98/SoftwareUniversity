function calculateBill(array) {
    let products = array.filter( (el, i) => i % 2 === 0);
    let prices = array.filter( (el, i) => i % 2 === 1).map(Number);

    let totalPrice = prices.reduce( (a, b) => a + b);

    console.log(`You purchased ${products.join(", ")} for a total sum of ${totalPrice}`);
}

/* Uncomment to test:
calculateBill(['Beer Zagorka', '2.65', 'Tripe soup', '7.80','Lasagna', '5.69']);
calculateBill(['Cola', '1.35', 'Pancakes', '2.88']);
*/