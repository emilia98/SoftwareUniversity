function cookAPizza(str, len){
    let ingredients = str.split(' ');
    let searchedLength = parseInt(len);

    let ingredientsUsed = new Array(10);
    let counter = 0;

    for (let ingredient of ingredients) {
        if(ingredient.length == searchedLength){
            ingredientsUsed[counter] = ingredient;
            counter++;
        }
    }
    ingredientsUsed = ingredientsUsed.slice(0, Math.min(counter, 10));

    ingredientsUsed.forEach(el => console.log(`Adding ${el}.`));
    console.log(`Made pizza with total of ${ingredientsUsed.length} ingredients.`);
    console.log(`The ingredients are: ${ingredientsUsed.join(", ")}.`);
}

cookAPizza("cheese flour tomato bread olives salami pepperoni", 6);
cookAPizza("cheese flour tomato bread olives salami pepperoni", 9);
cookAPizza("cheese flour tomato bread olives salami pepperoni orange cheese flour tomato bread olives salami pepperoni orange cheese", 6);