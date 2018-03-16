function createComputerHierarchy(){

    class ComponentManufactory{
        constructor(manufacturer){
            if(new.target === ComponentManufactory){
                throw new Error("Cannot create an instance of an abstract class!");
            }
            this.manufacturer = manufacturer;
        }
    }

    class Keyboard extends ComponentManufactory{
        constructor(manufacturer, responseTime){
            super(manufacturer);
            this.responseTime = responseTime;
        }
    }

    class Monitor extends ComponentManufactory{
        constructor(manufacturer, width, height){
            super(manufacturer);
            this.width = width;
            this.height = height;
        }
    }

    class Battery extends ComponentManufactory{
        constructor(manufacturer, expectedLife){
            super(manufacturer);
            this.expectedLife = expectedLife;
        }
    }

    class Computer extends ComponentManufactory{
        constructor(manufacturer, processorSpeed, ram, hardDiskSpace){
            if(new.target === Computer){
                throw new TypeError("Cannot create an instance of an abstract class!");
            }

            super(manufacturer);
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
                throw new TypeError("The passed value is not an instace of Battery class!");
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

    return {
        Keyboard,
        Monitor,
        Battery,
        Computer,
        Laptop,
        Desktop
    };
}

/* Uncomment to test:
let classes = createComputerHierarchy();
let Computer = classes.Computer;
let Laptop = classes.Laptop;
let Desktop = classes.Desktop;
let Monitor = classes.Monitor;
let Battery = classes.Battery;
let Keyboard = classes.Keyboard;

let keyboard = new Keyboard('Logitech',70);
let monitor = new Monitor('Benq',28,18);
let desktop = new Desktop("JAR Computers",3.3,8,1,keyboard,monitor);
console.log(desktop.manufacturer);
//expect(desktop.manufacturer).to.equal("JAR Computers",'Expected manufacturer did not match.');
console.log(desktop.processorSpeed);
//expect(desktop.processorSpeed).to.be.closeTo(3.3,0.01,'Expected processor speed did not match.');
console.log(desktop.ram);
//expect(desktop.ram).to.equal(8,'Expected RAM did not match.');
console.log(desktop.hardDiskSpace);
//expect(desktop.hardDiskSpace).to.equal(1,'Expected hard disk space did not match.');
console.log(desktop.keyboard);
//expect(desktop.keyboard).to.equal(keyboard,'Expected keyboard did not match.');
console.log(desktop.monitor);
//expect(desktop.monitor).to.equal(monitor,'Expected monitor did not match.');
*/