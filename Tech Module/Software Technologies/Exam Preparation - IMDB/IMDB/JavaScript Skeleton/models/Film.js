const mongoose = require('mongoose');

let filmSchema = mongoose.Schema({
    name: {type: 'string', required: 'true', minlength: 1},
    genre: {type: 'string', required: 'true', minlength: 1},
    director: {type: 'string', required: 'true', minlength: 1},
    year: {type: 'number', required: 'true'},
});

let Film = mongoose.model('Film', filmSchema);

module.exports = Film;