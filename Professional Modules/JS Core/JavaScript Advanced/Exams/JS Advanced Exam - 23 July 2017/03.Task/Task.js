// The problem was that the overdue property hasn't changed it's value dynamically
class Task{
    constructor(title, deadline){
        this.title = title;
        this.deadline = deadline;
        this.status = "Open";
        this.isOverdue = false;
    }

    get status(){
        return this._status;
    }

    set status(value){
        if(value === "Complete"){
            this.isOverdue = false;
        }else{
            if(this.deadline.getTime() <= Date.now()){
                this.isOverdue = true;
            }else{
                this.isOverdue = false;
            }
        }
        this._status = value;
    }

    get isOverdue(){
        if(this.deadline.getTime() <= Date.now()){
            this._overdue = true;
        }
        return this._overdue;
    }

    set isOverdue(value){
        this._overdue = value;
    }

    get deadline(){
        return this._deadline;
    }

    set deadline(value){
        if(value.getTime() < Date.now()){
            throw new Error("Deadline cannot be before the creation date!");
        }

        this.isOverdue = false;
        this._deadline = value;
    }

    static comparator(a, b){
        let now = Date.now();

        if(a.deadline.getTime() <= now){
            a.isOverdue = true;
        }

        if(b.deadline.getTime() <= now){
            b.isOverdue = true;
        }

        let taskA = getNumber(a);
        let taskB = getNumber(b);

        if(taskA > taskB) return -1;
        if(taskA < taskB) return 1;

        if(a.status === b.status || (a.isOverdue && b.isOverdue)){
            if(a.deadline.getTime() > b.deadline.getTime()){
                return 1;
            }else if(a.deadline.getTime() < b.deadline.getTime()){
                return -1;
            }
            return 0;
        }

        function getNumber(task){
            if(task.isOverdue && task.status !== "Complete"){
                return 4;
            }
            if(task.status === "In Progress"){
                return 3;
            }
            if(task.status === "Open"){
                return 2;
            }
            if(task.status === "Complete"){
                return 1;
            }
        }
    }

    toString(){
        let isComplete = this.status === "Complete";

        if(this.deadline.getTime() <= Date.now()){
            this.isOverdue = true;
        }

        let result = `[${getStatusIcon(this.status, this.isOverdue)}] ${this.title}`;

        if(isComplete === false){
            if(this.isOverdue){
                result += " (overdue)";
            }else{
                result += ` (deadline: ${this.deadline})`;
            }

        }
        return result;


        function getStatusIcon(status, isOverdue){
            if(isOverdue && status !== "Complete"){
                return "\u26A0";
            }

            switch(status){
                case "Open":  return "\u2731";
                case "In Progress": return "\u219D";
                case "Complete": return "\u2714";
            }
        }
    }
}


let date1 = new Date();
date1.setDate(date1.getDate() + 7); // Set date 7 days from now
let task1 = new Task('JS Homework', date1);
let date2 = new Date();
date2.setFullYear(date2.getFullYear() + 1); // Set date 1 year from now
let task2 = new Task('Start career', date2);
console.log(task1 + '\n' + task2);
let date3 = new Date();
date3.setDate(date3.getDate() + 3); // Set date 3 days from now
let task3 = new Task('football', date3);
// Create two tasks with deadline set to current time
let task4 = new Task('Task 4', new Date());
//console.log(task4.deadline)
//console.log(task4 + "");
let task5 = new Task('Task 5', new Date());
task1.status = 'In Progress';
task3.status = 'In Progress';
task5.status = "Complete";
let tasks = [task1, task2, task3, task4, task5];
setTimeout(() => {
    tasks.sort(Task.comparator);
    console.log(tasks.join('\n'));
}, 1000); // Sort and print one second later


let now = new Date();
console.log(now);
let task = new Task('New Task', new Date(now.setSeconds(now.getSeconds() + 3)));

console.log(task.isOverdue);
setTimeout(() => {
    console.log(task.deadline)
    console.log(task.isOverdue);
}, 4000);