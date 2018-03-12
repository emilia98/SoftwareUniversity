function solve(){
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

    return {
        Figure,
        Circle,
        Rectangle
    };
}

/* Uncomment to test:
let result = solve();
let Figure = result.Figure;
let Circle = result.Circle;
let Rectangle = result.Rectangle;

// let f = new Figure();       //Error
let c = new Circle(5);
console.log(c.area);        //78.53981633974483
console.log(c.toString());  //Circle - radius: 5
let r = new Rectangle(3,4);
console.log(r.area);        //12
console.log(r.toString());  //Rectangle - width: 3, height: 4
*/

