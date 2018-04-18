const expect = require('chai').expect;
const Sumator = require('./solution');


describe("Test Sumator Class", () => {
    let result = null;
    beforeEach(function(){
        result = new Sumator();
    });

    describe("General Tests", () => {
       it("Test if property data exists", () => {
           expect(result.hasOwnProperty("data")).to.be.true;
           expect(result.data.length).to.equal(0);
       });

        it("Test if property add() exists", () => {
            expect(typeof result.__proto__.add).to.equal("function");
        });

        it("Test if property sumNums() exists", () => {
            expect(typeof result.__proto__.sumNums).to.equal("function");
        });

        it("Test if property removeByFilter() exists", () => {
            expect(typeof result.__proto__.removeByFilter).to.equal("function");
        });

        it("Test if property toString() exists", () => {
            expect(typeof result.__proto__.toString).to.equal("function");
        });
    });

    describe("Test add()", () => {
        it("Test with no parameter", () => {
            result.add();
            expect(result.data[0]).to.equal(undefined);
        });

        it("Test with adding several parameters", () => {
            let array = [3.14, "Pesho", {age: 99}, [7, 12], true];

            for(let el of array){
                result.add(el);
            }

            for(let index = 0; index < array.length; index++){
                expect(result.data[index]).to.equal(array[index]);
            }
        });
    });

    describe("Test sumNums()", () => {
        it("Test when the array is empty", () => {
            expect(result.sumNums()).to.equal(0, "Incorrect sum!")
        });

        it("With all parameters correct", () => {
            let array = [5, 17, -3.5, 0, 0.0001, 0.0002];

            for(let el of array){
                result.add(el);
            }
            expect(result.sumNums()).to.equal(18.5003, "Incorrect sum!")

        });

        it("Test with both number and non-number parameters", () => {
            let array = [5, true, -3.5, 0, "0.0001", 0.0002];

            for(let el of array){
                result.add(el);
            }

            // We could have troubles with rounding the numbers
            expect(result.sumNums()).to.equal(1.5002, "Incorrect sum!")
        });

        it("Test with non-number parameters", () => {
            let array = ["5", true, "-3.5", false, ["0.0001", 0.0002], "Pesho"];

            for(let el of array){
                result.add(el);
            }

            // We could have troubles with rounding the numbers
            expect(result.sumNums()).to.equal(0, "Incorrect sum!")
        });
    });

    describe("Test removeByFilter()", () => {
        // CAUSE A PROBLEM??
        it("Test with parameter which is not a function", () => {
            let func = "pesho";
            result.removeByFilter(func);
            expect(result.data.length).to.equal(0);
        });

        it("Test with adding several parameters", () => {
            let func = x => x % 2 === 0;
            let array = [7, 12, -9, 3.2, 6];
            let expected = [];

            for(let el of array){
                result.add(el);
            }

            expected = array.filter( x => x % 2 !== 0);
            result.removeByFilter(func);

            for(let index = 0; index < array.length; index++){
                expect(result.data[index]).to.equal(expected[index]);
            }
        });
    });

    describe("Test toString()", () => {
        it("Test with no elements in the array", () => {
            expect(result.toString()).to.equal("(empty)");
        });

        it("Test with no elements in the array", () => {
            result.add(2);
            result.add(12);
            result.removeByFilter(x => x % 2 === 0);
            expect(result.toString()).to.equal("(empty)");
        });

        it("Test with several elements in the array", () => {
            let array = [3.14, "Pesho", {age: 99}, [7, 12], true];

            for(let el of array){
                result.add(el);
            }

            expect(result.toString()).to.equal(array.join(", "));
        });
    });
});