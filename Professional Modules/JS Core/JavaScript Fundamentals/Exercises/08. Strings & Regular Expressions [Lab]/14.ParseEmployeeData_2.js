function parseData(arr){
    let pattern = /^(([A-Z][a-zA-Z]*) - ([1-9][0-9]*) - ([A-Za-z0-9\- ]+))$/;
    let employeeData = [];

    for(let str of arr){
        let match = str.match(pattern);

        if(match){
            employeeData.push(
                {
                    name : match[2],
                    position : match[4],
                    salary : match[3]
                }
            );
        }
    }

    for (let employee of employeeData) {
        console.log(`Name: ${employee.name}`);
        console.log(`Position: ${employee.position}`);
        console.log(`Salary: ${employee.salary}`);
    }
}

/* Uncomment to test:
parseData(['Peter - 500 - Employee', 'Isacc - 1000 - CEO','Ivan - 500 - Employee',
]);
parseData(['Jonathan - 2000 - Manager', 'Peter - 1000 - Chuck', 'George - 1000 - Team Leader']);
parseData(['jonathan - 2000 - Manager', 'George - 1000.559 - Team Leader', 'Peter- 1000- Chuck', ]);
parseData(['Peter - 500 - Employee', 'Ivan - 500 - Employee', 'Isacc - 1000 - CEO - Leader', 'Jonathan - 2000 - Manager']);
*/

