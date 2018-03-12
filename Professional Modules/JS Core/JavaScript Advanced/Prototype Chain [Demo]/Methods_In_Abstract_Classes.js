class Figure{
    constructor(){
        if(this.constructor === Figure){
            throw new Error("Cannot create an instance!");
        }
    }

    get area(){
        switch(this.constructor){
            case Circle: {
                return Math.PI * this.radius * this.radius;
            }
            case Rectangle: {
                return this.width * this.height;
            }
            case Triangle: {
                let p = (this.a + this.b + this.c) / 2;
                return Math.sqrt(p * (p - this.a) * (p - this.b) * (p - this.c));
            }
        }
    }

    toString() {
        let props = [];
        for(let prop in this){
            props.push(`${prop}: ${this[prop]}`);
        }
        return `${this.constructor.name} - ${props.join(", ")}`;
    }
}

class Circle extends Figure{
    constructor(r){
        super();
        this.radius = r;
    }
}

class Rectangle extends Figure{
    constructor(w, h){
        super();
        this.width = w;
        this.height = h;
    }
}

class Triangle extends Figure{
    constructor(a, b, c){
        super();
        this.a = a;
        this.b = b;
        this.c = c;
    }
}

// let f = new Figure();       //Error
let c = new Circle(5);
console.log(c.area);        //78.53981633974483
console.log(c.toString());  //Circle - radius: 5
let r = new Rectangle(3,4);
console.log(r.area);        //12
console.log(r.toString());  //Rectangle - width: 3, height: 4
let t = new Triangle(3, 4, 5);
console.log(t.area); // 6
console.log("" + t); // Triangle - a: 3, b: 4, c: 5
