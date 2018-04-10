function validateRequests(arr){
    arr = arr.filter(el => el !== "");
    let hashPattern = arr.pop();
    let patterns = {
        // TRIM() -> NO
        // PROBLEM (SOLVED): single space between element caption and its value (not \s*)
        method: /^Method\s*: (GET|POST|DELETE|PUT)$/,
        credentials: /^Credentials\s*: (Basic|Bearer) ([A-Za-z0-9]+)$/,
        content: /^Content\s*: ([A-Za-z0-9\.]*)$/
    };
    let authType = null;
    let authToken = null;
    let method = null;
    let content = null;
    
    for(let index = 0; index < arr.length; index += 3){
        let [inputMethod, inputCredentials, inputContent] = arr.slice(index, index + 3);
        let invalidRequest = false;

        let matches = {
            method: inputMethod.match(patterns.method),
            credentials: inputCredentials.match(patterns.credentials),
            content: inputContent.match(patterns.content)
        };

        if(matches.method === null || matches.credentials === null || matches.content === null){
            invalidRequest = true;
        }else{
            authType = matches.credentials[1];
            authToken = matches.credentials[2];
            method = matches.method[1];
            content = matches.content[1];
        }

        if(invalidRequest){
            console.log("Response-Code:400");
            continue;
        }

        if(checkAuthType() === false){
            console.log(`Response-Method:${method}&Code:401`);
            continue;
        }

        if(checkAuthToken() === false){
            console.log(`Response-Method:${method}&Code:403`);
            continue;
        }

        console.log(`Response-Method:${method}&Code:200&Header:${authToken}`)
    }

    function checkAuthToken(){
        // A DIGIT or MORE THAN ONE DIGITS -> A DIGIT
        for(let index = 0; index < hashPattern.length; index += 2){
            let digit = parseInt(hashPattern[index]);
            let letter = hashPattern[index + 1];

            let occurrences = 0;
            for(let symbol of authToken){
                if(symbol === letter){
                    occurrences++;
                }
            }

            if(digit === occurrences){
                return true;
            }
        }
        return false;
    }

    function checkAuthType(){
        if(method !== "GET" && authType === "Basic"){
            return false;
        }

        return true;
    }
}

/* Uncomment to test:
validateRequests([
    "Method: GET",
    "Credentials: Bearer asd918721jsdbhjslkfqwkqiuwjoxXJIdahefJAB",
    "Content: users.asd.1782452.278asd",
    "Method: POST",
    "Credentials: Basic 028591u3jtndkgwndsdkfjwelfqkjwporjqebhas",
    "Content: Johnathan",
    "2q",
""]);

validateRequests([
    "Method: PUT",
    "Credentials: Bearer as9133jsdbhjslkfqwkqiuwjoxXJIdahefJAB",
    "Content: users.asd/1782452$278///**asd123",
    "Method: POST",
    "Credentials: Bearer 028591u3jtndkgwndskfjwelfqkjwporjqebhas",
    "Content: Johnathan",
    "Method: DELETE",
    "Credentials: Bearer 05366u3jtndkgwndssfsfgeryerrrrrryjihvx",
    "Content: This.is.a.sample.content",
    "2e5g",
    ""
]);

validateRequests([
    "Method: GET",
    "Credentials: Bearer 028591u3jtndkgwndskfjwelfqkjwporjqebhas",
    "Content: Johnathan",
    "Method: PUT",
    "Credentials: Basic as9133jsdbhjslkfqwkqiuwjoxXJIdahefJAB",
    "Content: users.asd/1782452$278///**asd123",
    "Method: POST",
    "Credentials: Basic 028591u3jtndkgwndskfjwelfqkjwporjqebhas",
    "Content: Johnathan",
    "Method: DELETE",
    "Credentials: Bearer 05366u3jtndkgwndssfsfgeryerrrrrryjihvx",
    "Content: This.is.a.sample.content",
    "2e5g",
]);
*/