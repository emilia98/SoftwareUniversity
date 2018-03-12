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

console.log(person instanceof Person); // true
console.log(person instanceof Teacher); // false
console.log(teacher instanceof Teacher); // true
console.log(teacher instanceof Person); // true
