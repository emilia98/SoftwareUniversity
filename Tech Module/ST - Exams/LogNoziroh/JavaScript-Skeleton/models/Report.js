const mongoose = require('mongoose');

let reportSchema = mongoose.Schema({
    status: {type: 'string', required: 'true'},
    message: {type: 'string', required: 'true', minlength: 1},
    origin: {type: 'string', required: 'true', minlength: 1},
});

let Report = mongoose.model('Report', reportSchema);

module.exports = Report;