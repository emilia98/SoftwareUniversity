function solve(){
    class Figure{
        constructor(){
            if(new.target === Figure){
                throw new Error("Cannot create an instance!");
            }
        }
    }

    class Circle extends Figure{
        constructor(r){
            super();
            this.radius = r;
        }

        get area(){
            return Math.PI * this.radius * this.radius;
        }

        toString() {
            return `${this.constructor.name} - radius: ${this.radius}`;
        }

    }

    class Rectangle extends Figure{
        constructor(w, h){
            super();
            this.width = w;
            this.height = h;
        }

        get area(){
            return this.width * this.height;
        }

        toString() {
            return `${this.constructor.name} - width: ${this.width}, height: ${this.height}`;
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

