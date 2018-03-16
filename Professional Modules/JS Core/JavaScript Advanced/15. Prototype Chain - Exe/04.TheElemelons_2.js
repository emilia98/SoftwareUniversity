function solve(){
    class Melon{
        constructor(weight, sort){
            if(new.target === Melon){
                throw new TypeError('Abstract class cannot be instantiated directly');
            }
            this.weight = weight;
            this.melonSort = sort;
        }

        toString(){
            return [
                `Element: ${this._element}`,
                `Sort: ${this.melonSort}`,
                `Element Index: ${this.elementIndex}`
            ].join('\n');
        }
    }

    class Watermelon extends Melon{
        constructor(weight, sort){
            super(weight, sort);
            this._elementIndex = weight * this.melonSort.length;
            this._element = "Water";
        }

        get elementIndex(){
            return this._elementIndex;
        }
    }

    class Firemelon extends Melon{
        constructor(weight, sort){
            super(weight, sort);
            this._elementIndex = weight * this.melonSort.length;
            this._element = "Fire";
        }

        get elementIndex(){
            return this._elementIndex;
        }
    }

    class Earthmelon extends Melon{
        constructor(weight, sort){
            super(weight, sort);
            this._elementIndex = weight * this.melonSort.length;
            this._element = "Earth";
        }

        get elementIndex(){
            return this._elementIndex;
        }
    }

    class Airmelon extends Melon{
        constructor(weight, sort){
            super(weight, sort);
            this._elementIndex = weight * this.melonSort.length;
            this._element = "Air";
        }

        get elementIndex(){
            return this._elementIndex;
        }
    }

    class Melolemonmelon extends Watermelon{
        constructor(weight, sort){
            super(weight, sort);
            this._elements = ["Fire", "Earth", "Air", "Water"];
            this._element = "Water";
        }

        morph(){
            this._element = this._elements.shift();
            this._elements.push(this._element);
        }
    }

    return {
        Melon,
        Watermelon,
        Firemelon,
        Earthmelon,
        Airmelon,
        Melolemonmelon
    };
}

/* Uncomment to test:
let result = solve();
let Melon = result.Melon;
let Watermelon = result.Watermelon;
let Firemelon = result.Firemelon;
let Earthmelon = result.Earthmelon;
let Airmelon = result.Airmelon;
let Melolemonmelon = result.Melolemonmelon;

// let test = new Melon(100, "Test");
//Throws error

let watermelon = new Watermelon(12.5, "Kingsize");
console.log(watermelon.toString());

let firemelon = new Firemelon(12.5, "Kingsize");
console.log(firemelon.toString());

let earthmelon = new Earthmelon(12.5, "Kingsize");
console.log(earthmelon.toString());

let airmelon = new Airmelon(12.5, "Kingsize");
console.log(airmelon.toString());

let hybrid = new Melolemonmelon(15, "Hybrid");
hybrid.morph();
console.log(hybrid.toString());
hybrid.morph();
console.log(hybrid.toString());
hybrid.morph();
console.log(hybrid.toString());

let classes = solve();
let test = new classes.Melolemonmelon(150, "Melo");

test.morph();
test.morph();
console.log(test.toString());
*/