function attachEventsListeners(){
    document.getElementById("convert").addEventListener("click", convert);

    function convert() {
        let input = document.getElementById("inputUnits").value;
        let output = document.getElementById("outputUnits").value;
        let distance = document.getElementById("inputDistance").value;
        let outputDistance = document.getElementById("outputDistance");

        let inputToMeters = findUnit(input, Number(distance), 1);
        let result = findUnit(output, inputToMeters, 2);
        outputDistance.value = result;
    }

    function findUnit(unit, value, option){
        if(unit === "km"){
            option === 1 ? value *= 1000 : value /= 1000;
        }else if(unit === "cm"){
            option === 1 ? value /= 100 : value *= 100;
        }else if(unit === "mm"){
            option === 1 ? value /= 1000 : value *= 1000;
        }else if(unit === "mi"){
            option === 1 ? value *= 1609.34 : value /= 1609.34;
        }else if(unit === "yrd"){
            option === 1 ?  value *= 0.9144 :  value /= 0.9144;
        }else if(unit === "ft"){
            option === 1 ? value *= 0.3048 : value /= 0.3048;
        }else if(unit === "in"){
            option === 1 ? value *= 0.0254 : value /= 0.0254;
        }
        return value;
    }
}