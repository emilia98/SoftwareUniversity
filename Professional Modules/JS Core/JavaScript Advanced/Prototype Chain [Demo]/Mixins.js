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

asCircle.call(Circle.prototype);

console.log(c.area());
console.log(c.perimeter());