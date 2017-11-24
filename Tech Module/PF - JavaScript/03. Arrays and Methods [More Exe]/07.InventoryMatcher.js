function matchInventory(arr1, arr2, arr3, arr){
    let names = arr1.slice(0, arr1.length);
    let quantities = arr2.slice(0, arr2.length).map(Number);
    let prices = arr3.slice(0, arr3.length).map(Number);
    let productsToFind = arr.slice(0, arr.length);

    let cnt = 0;
    let product = productsToFind[0];

    while(product != "done"){
        let index = names.indexOf(product);

        if(index > -1){
            let name = names[index];
            let quantity = quantities[index];
            let price = prices[index];

            console.log(`${name} costs: ${price}; Available quantity: ${quantity}`);
        }
        cnt++;
        product =  productsToFind[cnt];
    }

}

matchInventory(["Bread", "Juice", "Fruits", "Lemons"],
               ["10", "50", "20", "30"],
               ["2.34", "1.23", "3.42", "1.50"],
               ["Bread", "Juice", "done"]);

matchInventory(["Oranges", "Apples", "Nuts"],
               ["1500", "5000000", "2000000000"],
               ["2.3412", "1.23", "3.4250", "1.50"],
               ["Nuts", "done"]);






