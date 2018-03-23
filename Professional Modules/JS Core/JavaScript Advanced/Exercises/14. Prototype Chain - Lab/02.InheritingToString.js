function toStringExtension(){

    class Person{
        constructor(name, email){
            this.name = name;
            this.email = email;
        }

        toString() {
            let type = this.constructor.name;
            return `${type} (name: ${this.name}, email: ${this.email})`;
        }
    }

    class Teacher extends Person{
        constructor(name, email, subject){
            super(name, email);
            this.subject = subject;
        }

        toString() {
            return `${super.toString().slice(0, -1)}, subject: ${this.subject})`;
        }
    }

    class Student extends Person{
        constructor(name, email, course){
            super(name, email);
            this.course = course;
        }

        toString() {
            let inheritedString = super.toString();
            return `${inheritedString.substr(0, inheritedString.length - 1)}, course: ${this.course})`;
        }
    }

    return{
        Person,
        Teacher,
        Student
    };
}

/* Uncomment to test:
let result = toStringExtension();
let Person = result.Person;
let Teacher = result.Teacher;
let Student = result.Student;

let person = new Person("Pesho", "pesho@abv.bg");
let teacher = new Teacher("Maria", "maria@yahoo.com", "Geography");
let student = new Student("John", "john@doe.com", "PHP");
console.log("" + person);
console.log("" + teacher);
console.log("" + student);
*/