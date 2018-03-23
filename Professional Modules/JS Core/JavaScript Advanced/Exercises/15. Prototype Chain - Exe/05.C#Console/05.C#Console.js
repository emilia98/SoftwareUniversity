let expect = require('chai').expect;

class Console {

    static get placeholder() {
        return /{\d+}/g;
    }

    static writeLine() {
        let message = arguments[0];
        if (arguments.length === 1) {
            if (typeof (message) === 'object') {
                message = JSON.stringify(message);
                return message;
            }
            else if (typeof(message) === 'string') {
                return message;
            }
        }
        else {
            if (typeof (message) !== 'string') {
                throw new TypeError("No string format given!");
            }
            else {
                let tokens = message.match(this.placeholder).sort(function (a, b) {
                    a = Number(a.substring(1, a.length - 1));
                    b = Number(b.substring(1, b.length - 1));
                    return a - b;
                });
                if (tokens.length !== (arguments.length - 1)) {
                    throw new RangeError("Incorrect amount of parameters given!");
                }
                else {
                    for (let i = 0; i < tokens.length; i++) {
                        let number = Number(tokens[i].substring(1, tokens[i].length - 1));
                        if (number !== i) {
                            throw new RangeError("Incorrect placeholders given!");
                        }
                        else {
                            message = message.replace(tokens[i], arguments[i + 1])
                        }
                    }
                    return message;
                }
            }
        }
    }
}

describe("Test the C# Console", () => {
    describe("Test with only one parameter passed", () => {
        it("Test if the parameter is a string", () => {
            expect(Console.writeLine("Great")).to.equal("Great");
        });

        it("Test if the parameter is a string", () => {
            expect(Console.writeLine("")).to.equal("");
        });

        it("Test when parameters are more than placeholders", () => {
            expect(Console.writeLine("Hello, {0} {1}")).to.equal("Hello, {0} {1}");
        });

        it("Test if the parameter is an object", () => {
            expect(Console.writeLine({msg: 'Hello'})).to.equal("{\"msg\":\"Hello\"}");
        });

        it("Test if the parameter is an object", () => {
            expect(Console.writeLine(['Hello', 48])).to.equal("[\"Hello\",48]");
        });
    });


    describe("Test the first parameter is incorrect", () => {
       it("Test if the first parameter is not a string", () => {
           //let c = new Console();
           expect(() => Console.writeLine(7, 7, 8)).to.throw(TypeError);
       });
       it("Test if there are no parameters", () => {
           //let c = new Console();
           expect(() => Console.writeLine()).to.throw(TypeError);
       });
   });

    describe("Test for different count of parameters and placeholders", () => {
        it("Test when parameters are more than placeholders", () => {
            expect(() => Console.writeLine("Hello, {0} {1}", "Pesho", "Ivanon", "Peshev")).to.throw(RangeError);
        });

        /*
        it("Test when parameters are more than placeholders", () => {
            expect(() => Console.writeLine("Hello, {0} {1}")).to.throw(RangeError);
        });
        */

        it("Test when placeholders are more than parameters", () => {
            expect(() => Console.writeLine("Hello, {0} {1} {2}", "Pesho", "Ivanon")).to.throw(RangeError);
        });
    });

    describe("Test for invalid placeholders", () => {
        it("Test with negative numbers as placeholder", () => {
            expect(() => Console.writeLine("Hello, {0} {-1}", "Pesho", "Ivanon", "Peshev")).to.throw(RangeError);
        });

        it("Test with number, which is greater than the count of argument, as placeholder", () => {
            expect(() => Console.writeLine("Hello, {0} {10}", "Pesho", "Ivanon", "Peshev")).to.throw(RangeError);
        });

        it("Test with floating-point number as placeholder", () => {
            expect(() => Console.writeLine("Hello, {0} {2.6}", "Pesho", "Ivanon")).to.throw(RangeError);
        });
    });

    describe("Test for valid parameters and placeholders", () => {
        it("Test with all valid #1", () => {
            expect(Console.writeLine("Hello, {0} {1}", "Pesho", "Ivanov")).to.equal("Hello, Pesho Ivanov");
        });

        it("Test with all valid #2", () => {
            expect(Console.writeLine("Hello, {0}", "world")).to.equal("Hello, world");
        });

        it("Test with all valid #3", () => {
            expect(Console.writeLine("{0}{1}{2}{3}{4}{5}{6}{7}{8}{9}{10}", 0,1,2,3,4,5,6,7,8,9,10)).to.equal("012345678910");
        });
    });
});