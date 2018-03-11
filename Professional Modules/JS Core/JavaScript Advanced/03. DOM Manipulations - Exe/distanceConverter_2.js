function attachEventsListeners(){
    document.getElementById("convert").addEventListener("click", convert);

    function convert() {
        let inputIndex = document.getElementById("inputUnits").selectedIndex;
        let outputIndex = document.getElementById("outputUnits").selectedIndex;

        let distance = Number(document.getElementById("inputDistance").value);
        let outputDistance = document.getElementById("outputDistance");

        let division = [1000, 1, 100, 1000, 1609.34, 0.9144, 0.3048, 0.0254];
        let inputOperations = ["*", "*", "/", "/", "*", "*", "*", "*"];
        let outputOperations = ["/", "*","*", "*", "/", "/", "/", "/"];

        let inputToMeters = returnConverted(inputOperations[inputIndex],
            division[inputIndex], distance);
        let result = returnConverted(outputOperations[outputIndex],
            division[outputIndex], inputToMeters);

        outputDistance.value = result;
    }

    function returnConverted(operator, division, value){
        return operator === '*' ? value *= division : value /= division;
    }
}