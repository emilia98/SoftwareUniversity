function parseAngular(arr){
    arr = arr.filter(el => el !== "");
    // Start/End of Line -> NO
    let element_pattern = /\$(app|controller|model|view)='([^']*)'(&app='([^']*)'){0,1}/;
    let parserData = {};
    let storeForLaterUsage = [];

    for(let element of arr){
        let match = element.match(element_pattern);
        let type = match[1];
        let moduleName = null;
        let elementName = null;

        if(type === "app"){
            moduleName = match[2];

            if(!(moduleName in parserData)){
                parserData[moduleName] = {
                    controllers: [],
                    models: [],
                    views: []
                }
            }
        }else{
            moduleName = match[4];
            elementName = match[2];

            // No need to check for unique element in a module
            if(moduleName in parserData){
                parserData[moduleName][type + "s"].push(elementName)

            }else{
                storeForLaterUsage.push({
                    type,
                    elementName,
                    moduleName
                })
            }
        }
    }

    for(let entry of storeForLaterUsage){
        if((entry.moduleName in parserData)){
            parserData[entry.moduleName][entry.type + "s"].push(entry.elementName);
        }
    }

    let sortedKeys = Object.keys(parserData).sort((a, b) => {
        let objA = parserData[a];
        let objB = parserData[b];

        if(objA.controllers.length > objB.controllers.length){
            return -1
        }
        if(objA.controllers.length < objB.controllers.length){
            return 1
        }

        if(objA.models.length > objB.models.length){
            return 1
        }
        if(objA.models.length < objB.models.length){
            return -1
        }
    });

    let sortedParser = {};
    for(let key of sortedKeys){
        sortedParser[key] = {
            controllers: parserData[key].controllers.sort(),
            models: parserData[key].models.sort(),
            views: parserData[key].views.sort(),
        }
    }
    console.log(JSON.stringify(sortedParser));
}

/* Uncomment to test:
parseAngular([
    "$app='MyApp'",
    "$controller='My Controller'&app='MyApp'",
    "$model='My Model'&app='MyApp'",
    "$view='My View'&app='MyApp'",
    ""
]);

parseAngular([
    "$controller='PHPController'&app='Language Parser'",
    "$controller='JavaController'&app='Language Parser'",
    "$controller='C#Controller'&app='Language Parser'",
    "$controller='C++Controller'&app='Language Parser'",
    "$app='Garbage Collector'",
    "$controller='GarbageController'&app='Garbage Collector'",
    "$controller='SpamController'&app='Garbage Collector'",
    "$app='Language Parser'",
    ""
]);
*/