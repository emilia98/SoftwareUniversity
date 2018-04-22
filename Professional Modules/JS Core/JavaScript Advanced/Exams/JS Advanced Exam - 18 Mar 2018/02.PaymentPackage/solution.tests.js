let expect = require('chai').expect;
let PaymentPackage = require('./solution.js');

describe('Test Payment Package', () => {
    describe("General Tests", () => {
        it("Test if name property exists", () => {
            let payment = new PaymentPackage("Hello", 20)
            expect(PaymentPackage.prototype.hasOwnProperty("name")).to.equal(true);
        });

        it("Test if value property exists", () => {
            expect(PaymentPackage.prototype.hasOwnProperty("value")).to.equal(true);
        });

        it("Test if VAT property exists", () => {
            expect(PaymentPackage.prototype.hasOwnProperty("VAT")).to.equal(true);
        });

        it("Test if active property exists", () => {
            expect(PaymentPackage.prototype.hasOwnProperty("active")).to.equal(true);
        });

        it("Test if active property exists", () => {
            expect(typeof PaymentPackage.toString).to.equal("function");
        });
    });

    describe("Test instantiation", () => {
        it("Test with both arguments missing", () => {
            expect(() => new PaymentPackage()).to.throw(Error);
        });

        it("Test with one of the arguments missing", () => {
            expect(() => new PaymentPackage("Great")).to.throw(Error);
        });

        it("Test with incorrect name", () => {
            expect(() => new PaymentPackage("", 17)).to.throw(Error);
            expect(() => new PaymentPackage(["tosho"], 17)).to.throw(Error);
        });

        it("Test with incorrect value", () => {
            expect(() => new PaymentPackage("Pesho", "2.5")).to.throw();
            expect(() => new PaymentPackage("Pesho", -7)).to.throw();
        });


        it("Test with valid arguments", () => {
            let payment = new PaymentPackage("Services", 1500.5);
            expect(payment.name).to.equal("Services");
            expect(payment.value).to.equal(1500.5);
            expect(payment.VAT).to.equal(20);
            expect(payment.active).to.equal(true);
        })

    });

    describe("Test accessors", () => {
        it("Test accessor name", () => {
            let payment = new PaymentPackage("Service", 200);
            expect(payment.name).to.equal("Service");

            payment.name = "HR Services";
            expect(payment.name).to.equal("HR Services");

            expect(() => payment.name = "").to.throw(Error);
        });

        it("Test accessor value", () => {
            let payment = new PaymentPackage("Service", 200);
            expect(payment.value).to.equal(200);

            payment.value = 14.2;
            expect(payment.value).to.equal(14.2);

            payment.value = 0;
            expect(payment.value).to.equal(0);

            expect(() => payment.value = "250.5").to.throw(Error);
        });

        it("Test accessor VAT", () => {
            let payment = new PaymentPackage("Service", 200);

            expect(payment.VAT).to.equal(20);

            payment.VAT = 20;
            expect(payment.VAT).to.equal(20);

            payment.VAT = 14.2;
            expect(payment.VAT).to.equal(14.2);

            payment.VAT = 0;
            expect(payment.VAT).to.equal(0);

            expect(() => payment.VAT = -20).to.throw(Error);
            expect(() => payment.VAT = "250.5").to.throw(Error);
        });

        it("Test accessor active", () => {
            let payment = new PaymentPackage("Service", 200);

            expect(payment.active).to.equal(true);

            payment.active = false;
            expect(payment.active).to.equal(false);

            payment.active = true;
            expect(payment.active).to.equal(true);

            expect(() => payment.active = -20).to.throw(Error);
            expect(() => payment.active = 0).to.throw(Error);
        });
    });

    describe("Test toString()", () => {
        it("Test with active === true", () => {
            let payment = new PaymentPackage('Transfer Fee', 100);

            let result = [
                "Package: Transfer Fee",
                `- Value (excl. VAT): 100`,
                `- Value (VAT 20%): 120`
            ];

            expect(payment.toString()).to.equal(result.join("\n"));
        });

        it("Test with active === false", () => {
            let payment = new PaymentPackage('Transfer Fee', 100);
            payment.active = false;
            payment.VAT = 10;

            let withVat = 100 * (1 + 10 / 100);
            let result = [
                "Package: Transfer Fee (inactive)",
                `- Value (excl. VAT): 100`,
                `- Value (VAT 10%): ${withVat}`
            ];

            expect(payment.toString()).to.equal(result.join("\n"));
        });
    });
})