function solve(){
    class Employee{
        constructor(name, age){
            if(new.target === Employee){
                throw new Error("Cannot create an instance from an abstract class!");
            }
            this.name = name;
            this.age = age;
            this.salary = 0;
            this.tasks = [];
        }

        work(){
            let currentTask = this.tasks.shift();
            console.log(currentTask);
            this.tasks.push(currentTask);
        }

        collectSalary(){
            let salary = this.salary;

            if(this.dividend !== undefined){
                salary += this.dividend;
            }
            console.log(`${this.name} received ${salary} this month.`);
        }
    }

    class Junior extends Employee{
        constructor(name, age){
            super(name, age);

            this.tasks = [
                `${this.name} is working on a simple task.`
            ];
        }
    }

    class Senior extends Employee{
        constructor(name, age){
            super(name, age);

            this.tasks = [
                `${this.name} is working on a complicated task.`,
                `${this.name} is taking time off work.`,
                `${this.name} is supervising junior workers.`
            ];
        }
    }

    class Manager extends Employee{
        constructor(name, age){
            super(name, age);

            this.dividend = 0;
            this.tasks = [
                `${this.name} scheduled a meeting.`,
                `${this.name} is preparing a quarterly report.`
            ];
        }
    }

    return {
        Employee,
        Junior,
        Senior,
        Manager
    }
}

/* Uncomment to test:
let result = solve();
let guy1 = new result.Junior('Peter', 27);
guy1.salary = 1200;
guy1.collectSalary();
guy1.work();
console.log(guy1.age);

let guy2 = new result.Senior('Ivan', 33);
guy2.salary = 1200;
guy2.collectSalary();
guy2.work();
guy2.work();
guy2.work();
guy2.work();
console.log(guy2.age);

let guy3 = new result.Manager('Petranka', 36);
guy3.salary = 5200;
guy3.dividend = 800;
guy3.collectSalary();
guy3.work();
guy3.work();
guy3.work();
console.log(guy3.age);
*/

