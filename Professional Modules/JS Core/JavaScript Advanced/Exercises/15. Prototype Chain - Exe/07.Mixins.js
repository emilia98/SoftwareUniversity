class Keyboard{
    constructor(manufacturer, responseTime){
        this.manufacturer = manufacturer;
        this.responseTime = responseTime;
    }
}

class Monitor{
    constructor(manufacturer, width, height){
        this.manufacturer = manufacturer;
        this.width = width;
        this.height = height;
    }
}

class Battery{
    constructor(manufacturer, expectedLife){
        this.manufacturer = manufacturer;
        this.expectedLife = expectedLife;
    }
}

class Computer{
    constructor(manufacturer, processorSpeed, ram, hardDiskSpace){
        if(new.target === Computer){
            throw new TypeError("Cannot create an instance of an abstract class!");
        }

        this.manufacturer = manufacturer;
        this.processorSpeed = processorSpeed;
        this.ram = ram;
        this.hardDiskSpace = hardDiskSpace;
    }
}

class Laptop extends Computer{
    constructor(manufacturer, processorSpeed, ram, hardDiskSpace, weight, color, batteryToAdd){
        super(manufacturer, processorSpeed, ram, hardDiskSpace);
        this.weight = weight;
        this.color = color;
        this.battery = batteryToAdd;
    }

    get battery(){
        return this._battery;
    }

    set battery(batteryToAdd){
        if(!(batteryToAdd instanceof Battery)){
            throw new TypeError("Te passed value is not an instace of Battery class!");
        }
        this._battery = batteryToAdd;
    }
}

class Desktop extends Computer{
    constructor(manufacturer, processorSpeed, ram, hardDiskSpace, keyboardToAdd, monitorToAdd){
        super(manufacturer, processorSpeed, ram, hardDiskSpace);
        this.keyboard = keyboardToAdd;
        this.monitor = monitorToAdd;
    }

    get keyboard(){
        return this._keyboard;
    }

    set keyboard(keyboardToAdd){
        if(!(keyboardToAdd instanceof Keyboard)){
            throw new TypeError("The passed value is not an instance of Keyboard class!");
        }
        this._keyboard = keyboardToAdd;
    }

    get monitor(){
        return this._monitor;
    }

    set monitor(monitorToAdd){
        if(!(monitorToAdd instanceof Monitor)){
            throw new TypeError("The passed value is not an instance of Monitor class!");
        }
        this._monitor = monitorToAdd;
    }
}

function createMixins(){
    function computerQualityMixin(classToExtend){
        classToExtend.prototype.getQuality = function(){
            return (this.processorSpeed + this.ram + this.hardDiskSpace) / 3;
        };

        classToExtend.prototype.isFast = function(){
            return this.processorSpeed > (this.ram / 4);
        };

        classToExtend.prototype.isRoomy = function(){
            return this.hardDiskSpace > Math.floor(this.ram * this.processorSpeed);
        };
    }

    function styleMixin(classToExtend){
        classToExtend.prototype.isFullSet = function(){
            return (this.manufacturer === this.monitor.manufacturer && this.manufacturer === this.keyboard.manufacturer);
        };

        classToExtend.prototype.isClassy = function(){
            return this.battery.expectedLife >= 3 &&
                (this.color === "Silver" || this.color === "Black") &&
                this.weight < 3;
        }
    }

    return {
        computerQualityMixin,
        styleMixin
    };
}

/* Uncomment to test:
let mixins = createMixins();
let computerQualityMixin = mixins.computerQualityMixin;
let styleMixin = mixins.styleMixin;

computerQualityMixin(Desktop);
styleMixin(Desktop);
computerQualityMixin(Laptop);
styleMixin(Laptop);

let keyboard = new Keyboard('Logitech',70);
let keyboard2 = new Keyboard('A-4',70);
let monitor = new Monitor('Logitech',28,18);
let battery = new Battery('Energy',3);
let laptop = new Laptop("Hewlett Packard",2.4,4,0.5,2.99,"Silver",battery);
let laptop2 = new Laptop("Hewlett Packard",2.4,12,0.5,2.99,"Silver",battery);
let laptop3 = new Laptop("Hewlett Packard",2.4,4,12,3.12,"Silver",battery);
let desktop = new Desktop("Logitech",3.3,8,1,keyboard,monitor);
let desktop2 = new Desktop("Logitech",1.9,8,128,keyboard2,monitor);

console.log(desktop.getQuality()); // = 4.1
console.log(laptop.getQuality()); // = 2.3

console.log(desktop.isFast()); // true
console.log(desktop2.isFast()); // false
console.log(laptop.isFast()); // true
console.log(laptop2.isFast()); // false

console.log(desktop.isRoomy()); // false
console.log(desktop2.isRoomy()); // true

console.log(desktop.isFullSet()); // true
console.log(desktop2.isFullSet()); // false

console.log(laptop.isClassy()); // true
console.log(laptop3.isClassy()); // false
*/