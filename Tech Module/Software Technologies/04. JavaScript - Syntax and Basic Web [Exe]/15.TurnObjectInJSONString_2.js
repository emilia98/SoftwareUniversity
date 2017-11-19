function stringifyObject(array){
    let object = {};
    let pairs  = array.forEach(el => {
        let [key, value] = el.split(" -> ");

        object[key] = (key == "grade" || key == "age") ? Number(value) : value;
    });

    console.log(JSON.stringify(object));
}

/* Uncomment to test:
stringifyObject(["name -> Angel", "surname -> Georgiev", "age -> 20", "grade -> 6.00", "date -> 23/05/1995", "town -> Sofia"]);
*/
