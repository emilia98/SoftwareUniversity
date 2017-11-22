var express = require('express');
var router = express.Router();

/* GET home page. */
router.get('/', function(req, res, next) {
  //-> Worse way -> DO NOT USE IT:
  // res.send(`<h1>Welcoafsjkfjkasf</h1>`);
  res.render('index',
            { title: 'ExpressJS', //render: /views/index.hbs (using layouts.hbs)
              name: 'Emilia',
              users:[
                { name: "Pesho", email: "pesho@abv.bg" },
                { name: "Ivancho", email: "ivancho@abv.bg" },
                { name: "Mariika", email: "mariika@abv.bg" },
                { name: "Petya", email: "petya@abv.bg" },
              ]
            }
            );
});

module.exports = router;
