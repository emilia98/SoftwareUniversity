function concatenateData([arg1, arg2, arg3, arg4]){
    let firstName = arg1,
        lastName = arg2,
        age = Number(arg3),
        town = arg4;

    console.log(`You are ${firstName} ${lastName}, a ${age}-years old` +
        ` person from ${town}.`);
}

//Uncomment to test
//concatenateData(["Svetlin", "Nakov", "25", "V.Turnovo"]);