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
console.log(Person);
console.log(Teacher);
console.log();
console.log(Object.getPrototypeOf(teacher)); // Teacher {}
console.log(Object.getPrototypeOf(Teacher)); // [Function: Person]
console.log(Object.getPrototypeOf(Person)); // [Function]
console.log(Object.getPrototypeOf(Function)); // [Function]
console.log(Object.getPrototypeOf(Object.getPrototypeOf(Function))); // {}
console.log(Object.getPrototypeOf(Object.getPrototypeOf(Object.getPrototypeOf(Function)))); // null

console.log();
console.log(Object.getPrototypeOf(teacher) === Teacher); // false
console.log(Object.getPrototypeOf(teacher) === Teacher.prototype); // true
console.log(teacher.__proto__ === Teacher.prototype); // true
console.log(teacher.__proto__ === Teacher.__proto__); // false
console.log(Teacher.__proto__ === Person); // true
console.log(Object.getPrototypeOf(Teacher.prototype));
// instance.__proto__ == className.prototype
// __proto__ of Teacher (or parent of Teacher) === Person