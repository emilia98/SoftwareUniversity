function solve(){
    class Person{
        constructor(name, email){
            this.name = name;
            this.email = email;
        }
    }

    class Teacher extends Person{
        constructor(name, email, subject){
            super(name, email);
            this.subject = subject;
        }
    }

    return {
        Person,
        Teacher
    };
}

/* Uncomment to test:
let result = solve();
let Person = result.Person;
let Teacher = result.Teacher;

let person = new Person("Pesho", "pesho@abv.bg");
let teacher = new Teacher("Maria", "maria@yahoo.com", "Geography")

console.log(person);
console.log(teacher);
*/