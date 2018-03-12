class Circle{
    constructor(r){
        this.radius = r;
    }
}

function asCircle(){
    this.area = function(){
        return this.radius ** 2 * Math.PI;
    };

    this.perimeter = function(){
        return this.radius * 2 * Math.PI;
    }
}

let c = new Circle(10);
console.log(c);

asCircle.call(c);

console.log(c.area());
console.log(c.perimeter());

let c2 = new Circle(12);
console.log(c2);
// console.log(c2.area()); // c2.area is not a function
asCircle.call(c2);
console.log(c2.area());
console.log(c2.perimeter());