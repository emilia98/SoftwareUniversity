class Person{
    constructor(name, email){
        if(new.target === Person){
            throw new Error("Cannot create an instance of an abstract class!");
        }
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

/*
    If we have an abstract class Person, we can use it as a template of another children classes, but instances cannot be created from it.
 */
let person =  new Person("Pesho", "pesho@abv.bg");
let teacher = new Teacher("Ivan", "ivan@abv.bg", "History");

console.log(Person);
console.log(Teacher);