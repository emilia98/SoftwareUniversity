function solve() {
    class Balloon{
        constructor(color, gasWeight){
            this.color = color;
            this.gasWeight = gasWeight;
        }
    }

    class PartyBalloon extends Balloon{
        constructor(color, gasWeight, ribbonColor, ribbonLength){
            super(color, gasWeight);
            this._ribbon = {
                color: ribbonColor,
                length: ribbonLength
            };
        }

        get ribbon(){
            return this._ribbon;
        }
    }

    class BirthdayBalloon extends PartyBalloon{
        constructor(color, gasWeight, ribbonColor, ribbonLength, text){
            super(color, gasWeight, ribbonColor, ribbonLength);
            this._text = text;
        }

        get text(){
            return this._text;
        }
    }
    return {
        Balloon,
        PartyBalloon,
        BirthdayBalloon
    }
}

/* Uncomment to test:
let classes = solve();
let Balloon = classes.Balloon;
let PartyBalloon = classes.PartyBalloon;
let BirthdayBalloon = classes.BirthdayBalloon;

let balloon = new Balloon("Blue", 15);
console.log(balloon);
// Balloon { color: 'Blue', gasWeight: 15 }

let party = new PartyBalloon("Tumno-bqlo", 20.5, "Svetlo-cherno", 10.25);
let ribbon = party.ribbon;
console.log(ribbon);
// { color: 'Svetlo-cherno', length: 10.25 }

let birthday = new BirthdayBalloon("Tumno-bqlo", 20.5, "Svetlo-cherno", 10.25, "Happy Birthday!!!");
let text = birthday.text;
console.log(text);
// Happy Birthday!!!
*/