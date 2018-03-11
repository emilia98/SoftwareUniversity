function addItem(){
    let text = document.querySelector("#newItemText");
    let value = document.querySelector("#newItemValue");
    let option = `<option value="${value.value}">${text.value}</option>`;

   document.querySelector("#menu").innerHTML += option;

   text.value = "";
   value.value = "";
}