function parseData(arr){
    let pattern = /^(([A-Z][A-Za-z]*) - ([1-9][0-9]*) - ([A-Za-z\-0-9 ]+))$/;

    for(let str of arr){
        let matches = pattern.exec(str);

        if(matches){
            console.log(`Name: ${matches[2]}`);
            console.log(`Position: ${matches[4]}`);
            console.log(`Salary: ${matches[3]}`);
        }
    }
}

/* Uncomment to test:
parseData(['Peter - 500 - Employee', 'Isacc - 1000 - CEO','Ivan - 500 - Employee',
]);
parseData(['Jonathan - 2000 - Manager', 'Peter - 1000 - Chuck', 'George - 1000 - Team Leader']);
parseData(['jonathan - 2000 - Manager', 'George - 1000.559 - Team Leader', 'Peter- 1000- Chuck', ]);
parseData(['Peter - 500 - Employee', 'Ivan - 500 - Employee', 'Isacc - 1000 - CEO - Leader', 'Jonathan - 2000 - Manager']);
*/
