function upgradeMatcher(arr1, arr2, arr3, arr){
    let names = arr1.slice(0, arr1.length);
    let quantities = arr2.slice(0, arr2.length).map(Number);
    let prices = arr3.slice(0, arr3.length).map(Number);
    let productsToFind = arr.slice(0, arr.length);

    let size = arr1.length;
    let index = 0;
    let splitProduct = productsToFind[0].split(' ');

    quantities = fillMissedQuantites(quantities, size);

    while(splitProduct[0] != "done"){
        let productName = splitProduct[0];
        let searchedQuantity = Number(splitProduct[1]);
        let indexOfProduct = names.indexOf(productName);

        let name = names[indexOfProduct];
        let price = prices[indexOfProduct];
        let quantity = 0;

        if(indexOfProduct >= 0 && indexOfProduct < size){
            quantity = quantities[indexOfProduct];
        }

        if(quantity > 0 && quantity - searchedQuantity >= 0){
            let totalPriceOfOrder = searchedQuantity * price;
            console.log(`${name} x ${searchedQuantity} costs ${totalPriceOfOrder.toFixed(2)}`);
            quantities[indexOfProduct] -= searchedQuantity;
        }
        else{
            console.log(`We do not have enough ${name}`);
        }

        index++;
        splitProduct = productsToFind[index].split(' ');
    }

    function fillMissedQuantites(quantities, size){
        let allQuantities = new Array(size);
        for(let index = 0; index < size; index++){
            if(quantities[index] == undefined){
                allQuantities[index] = 0;
            }else{
                allQuantities[index] = quantities[index];
            }
        }
        return allQuantities;
    }
}

upgradeMatcher(["Bread", "Juice", "Fruits", "Lemons", "Beer"],
    ["10", "50", "20", "30"],
    ["2.34", "1.23", "3.42", "1.50", "3.00"],
    ["Bread 10", "Juice 5 ", "Beer 20",  "done"]);

upgradeMatcher(["Tomatoes", "Onions", "Lemons"],
    ["10000", "2000"],
    ["5.40", "3.20", "2.20"],
    ["Tomatoes 5000", "Tomatoes 5000", "Tomatoes 1", "done"]);



