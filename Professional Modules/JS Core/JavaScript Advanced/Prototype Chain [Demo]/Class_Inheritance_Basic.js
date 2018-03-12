/*
    super() -> calls the constructor of its parent, sets the values of the properties of the parent, and after it's work has done, the constructor of the current class sets its own properties
 */
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
console.log(person);
let teacher = new Teacher("Ivan", "ivan@abv.bg", "History");
console.log(teacher);

console.log(Person);
console.log(Teacher);