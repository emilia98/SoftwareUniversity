class Person{
    constructor(name, email){
        this.name = name;
        this.email = email;
    }

    toString() {
        let className = this.constructor.name;
        return `${className} (Name: ${this.name}, Email: ${this.email})`;
    }
}

class Teacher extends Person{
    constructor(teacherName, teacherEmail, subject){
        super(teacherName, teacherEmail);
        this.subject = subject;
    }

    toString() {
        let className = this.constructor.name;
        return `${className} (Name: ${this.name}, Email: ${this.email}), Subject: ${this.subject})`;
    }
}

let person =  new Person("Maria", "maria@abv.bg");
let teacher = new Teacher("Nikifor", "nikifor@abv.bg", "Maths");

console.log(person.toString());
console.log(teacher.toString());

teacher.salary = 1000;
console.log(teacher.salary); // 1000
console.log(person.salary); // undefined

person.town = "Kaspichan";
console.log(person.town); // Kaspichan
console.log(teacher.town); // undefined

Object.getPrototypeOf(person).age = 15;
//person.prototype.age = 15;
console.log(person.age);
console.log(teacher.age);

console.log(person);
person.age = 17; // we set a value to property age only on the instance, not to the prototype of the instance's class.
console.log(person); // Now we have a property age in the object
console.log(person.age);
console.log(Object.getPrototypeOf(person).age); // the age in the prototype of the instance stays the same
console.log(teacher.age);

console.log(Object.getPrototypeOf(teacher));

Teacher.