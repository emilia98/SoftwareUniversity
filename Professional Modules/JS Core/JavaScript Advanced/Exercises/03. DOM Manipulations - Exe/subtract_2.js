function subtract(){
    let a = Number(document.querySelector("#firstNumber").value);
    let b = Number(document.querySelector("#secondNumber").value);
    let result = document.querySelector("#result");
    result.textContent = a - b;
}