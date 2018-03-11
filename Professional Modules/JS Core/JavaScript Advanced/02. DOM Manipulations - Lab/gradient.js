function attachGradientEvents(){
    let gradient = document.getElementById("gradient");
    gradient.addEventListener("mousemove", moveGradient);
    gradient.addEventListener("mouseout", outGradient);
    let result = document.getElementById("result");
    
    function moveGradient(event){
        let x = event.offsetX;
        let width = event.target.clientWidth - 1;
        let percentage = Math.floor((x / width) * 100);
        result.textContent = `${percentage}%`;
    }
    
    function outGradient(event) {
        result.textContent = "";
    }
}