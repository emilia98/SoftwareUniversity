class Person{
    constructor(name, email){
        this.name = name;
        this.email = email;
    }

    toString() {
        /**
         this keyword point to the context, which called the method (i.e the instance's class, which called the method, not to the class, where the method is written)
         **/
        let className = this.constructor.name;
        return `${className} (Name: ${this.name}, Email: ${this.email})`;
    }
}

class Teacher extends Person{
    constructor(teacherName, teacherEmail, subject){
        super(teacherName, teacherEmail);
        this.subject = subject;
    }

    sayHello() {
        console.log("Hello");
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

/*
    All the methods in a class are chained to its prototype
 */
console.log(Teacher.prototype.toString); // [Function: toString]
console.log(Teacher.prototype.sayHello); // [Function: sayHello]
console.log(Person.prototype.toString); // [Function: toString]
console.log(Person.prototype.sayHello); // undefined (there is no function with this name)

console.log('-'.repeat(15));
console.log(teacher.age);
/*
Teacher.age = 15;
console.log(Teacher); // { [Function: Teacher] age: 15 }
*/
Teacher.prototype.age = 15;
console.log(Teacher.prototype);
console.log(teacher.age);
console.log(person.age);


