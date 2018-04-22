class PaymentProcessor{
    constructor(options){
        this.options = {
            types: ["service", "product", "other"],
            precision: 2
        };

        if(options !== undefined){
            if(options.types !== undefined){
                this.options.types = options.types;
            }

            if(options.precision !== undefined){
                this.options.precision = options.precision;
            }
        }

        this.payments = [];
    }

    registerPayment(id, name, type, value){
        if(typeof id !== "string" || id.length === 0){
            throw new Error("Id should be non-empty string!");
        }

        if(typeof name !== "string" || name.length === 0){
            throw new Error("Name should be non-empty string!");
        }

        let paymentIndex = this.getPaymentIndex(id);

        if(paymentIndex > -1){
            throw new Error("This id already exists!");
        }

        if(typeof value !== "number"){
            throw new Error("The value is not a number!");
        }

        if(this.options.types.indexOf(type) === -1){
            throw new Error("Invalid type!");
        }

        this.payments.push({
            id,
            name,
            value: value.toFixed(this.options.precision),
            type
        });
    }

    deletePayment(id){
        let paymentIndex = this.getPaymentIndex(id);

        if(paymentIndex === -1){
            throw new Error("This id does not exist!");
        }

        this.payments.splice(paymentIndex, 1);
    }

    get(id){
        let paymentIndex = this.getPaymentIndex(id);

        if(paymentIndex === -1){
            throw new Error("This id does not exist!");
        }

        let payment = this.payments[paymentIndex];
        let result = [
            `Details about payment ID: ${payment.id}`,
            `- Name: ${payment.name}`,
            `- Type: ${payment.type}`,
            `- Value: ${payment.value}`
        ];

        return result.join("\n");
    }

    setOptions(options){
        let types = options.types;
        let precision = options.precision;

        if(types !== undefined){
            this.options.types = types;
        }

        if(precision !== undefined){
            this.options.precision = precision;
        }
    }

    toString(){
        let result = [];
        let paymentsCount = this.payments.length;
        let totalBalance = 0;

        for(let payment of this.payments){
            totalBalance += Number(payment.value);
        }

        result.push("Summary:");
        result.push(`- Payments: ${paymentsCount}`);
        result.push(`- Balance: ${totalBalance.toFixed(this.options.precision)}`);

        return result.join("\n");
    }

    getPaymentIndex(id){
        let paymentIndex = -1;

        for(let index = 0; index < this.payments.length; index++){
            if(id === this.payments[index].id){
                paymentIndex = index;
                break;
            }
        }
        return paymentIndex;
    }
}

// Initialize processor with default options
const generalPayments = new PaymentProcessor();
generalPayments.registerPayment('0001', 'Microchips', 'product', 15000);
generalPayments.registerPayment('01A3', 'Biopolymer', 'product', 23000);
console.log(generalPayments.toString());

// Should throw an error (invalid type)
// generalPayments.registerPayment('E028', 'Rare-earth elements', 'materials', 8000);

generalPayments.setOptions({types: ['product', 'material']});
generalPayments.registerPayment('E028', 'Rare-earth elements', 'material', 8000);
console.log(generalPayments.get('E028'));
generalPayments.registerPayment('CF15', 'Enzymes', 'material', 55000);

// Should throw an error (ID not found)
// generalPayments.deletePayment('E027');
// Should throw an error (ID not found)
// generalPayments.get('E027');

generalPayments.deletePayment('E028');
console.log(generalPayments.toString());

// Initialize processor with custom types
const servicePyaments = new PaymentProcessor({types: ['service']});
servicePyaments.registerPayment('01', 'HR Consultation', 'service', 3000);
servicePyaments.registerPayment('02', 'Discount', 'service', -1500);
console.log(servicePyaments.toString());

// Initialize processor with custom precision
const transactionLog = new PaymentProcessor({precision: 5});
transactionLog.registerPayment('b5af2d02-327e-4cbf', 'Interest', 'other', 0.00153);
console.log(transactionLog.toString());
