let person = (function(){
    let id = 0;

    class Person{
        constructor(name){
            this.name = name;
            this.id = id++;
        }

        toString(){
            return `I'm ${this.name} with id ${this.id}.`;
        }
    }

    return {
        Person
    }
})();

let Person = person.Person;

let p = new Person("Pesho");
let p1 = new Person("Tosho");
let p2 = new Person("Mariika");

console.log(p.toString());
console.log(p1.toString());
console.log(p2.toString());