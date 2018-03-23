class Person{
    constructor(name, email){
        this.name = name;
        this.email = email;
    }
}

class Teacher extends Person{
    constructor(teacherName, teacherEmail, subject){
        super(teacherName, teacherEmail);
        this.subject = subject;
    }
}

let person =  new Person("Pesho", "pesho@abv.bg");
let teacher = new Teacher("Ivan", "ivan@abv.bg", "History");

console.log(person.constructor);
console.log(person.constructor.name);

if(teacher.constructor === Teacher){
    console.log("I am an instance of Teacher...");
}

