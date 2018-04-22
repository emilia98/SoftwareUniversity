function addProduct() {
    let inputs = document.querySelectorAll("#add-product input");
    let list = document.getElementById("product-list");
    let totatBillCell = document.querySelectorAll("#bill tfoot td")[1];
    let product = inputs[0];
    let price = inputs[1];

    if (product.value.length === 0 || price.value.length === 0) {
        return;
    }

    let tr = document.createElement("tr");
    let productCell = document.createElement("td");
    productCell.textContent = product.value;
    let priceCell = document.createElement("td");
    priceCell.textContent = price.value;

    tr.appendChild(productCell);
    tr.appendChild(priceCell);
    list.appendChild(tr);

    let totalBill = Number(totatBillCell.textContent) + Number(price.value);
    totatBillCell.textContent = totalBill;

    product.value = "";
    price.value = "";
}