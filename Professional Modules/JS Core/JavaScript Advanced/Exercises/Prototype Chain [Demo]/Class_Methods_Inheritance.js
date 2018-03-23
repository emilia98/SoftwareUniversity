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

    toString() {
        let className = this.constructor.name;
        return `${className} (Name: ${this.name}, Email: ${this.email}), Subject: ${this.subject})`;
    }
}

class Student extends Person{
    constructor(name, email, course){
        super(name, email);
        this.course = course;
    }

    toString() {
        let base = super.toString().slice(0, -1);
        return `${base}, Course: ${this.course})`;
    }
}



let person =  new Person("Maria", "maria@abv.bg");
let teacher = new Teacher("Nikifor", "nikifor@abv.bg", "Maths");

/**
 When calling a method from an instance of one class, the interpreter will search first in the class Teacher (or the class, which instance is this object) and if this method cannot be found there, the interpreter will search for it in it's parent(prototype), and so on.
 */
console.log(person.toString());
console.log(teacher.toString());

// If the instance's class doesn't have customized method, it will inherit the method of its parent (if the method exists). If we have a customized method and the parent of the class has this method too, the class doesn't have two methods with the same name, but overwrites parent's method.
let student = new Student("Pesho", "pesho@hotmail.bg", "PHP");
console.log(student.toString());
