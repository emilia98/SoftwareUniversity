const mongoose = require('mongoose');

let productSchema = mongoose.Schema({
    priority: {type: 'number', required: 'true'},
    name: {type: 'string', required: 'true', minlength: 1},
    quantity: {type: 'number', required: 'true'},
    status: {type: 'string', required: 'true', minlength: 1},
});

let Product = mongoose.model('Product', productSchema);

module.exports = Product;