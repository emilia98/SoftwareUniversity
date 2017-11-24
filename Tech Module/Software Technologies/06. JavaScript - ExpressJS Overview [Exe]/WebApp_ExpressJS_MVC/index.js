/*
    const -> analogy of 'include' (in C++) or 'using' (in C#)
*/
const express = require('express');
const app = express();
const routes = require('./config/routes/routes');
//
const port = 1400;

app.listen(port);

routes(app);
//app.use(bodyParser({urlencoded: true}));
////Handlebars config
//View engine setup
app.set('views', 'views');
app.set('view engine', 'hbs');



console.log(`App is listening on port ${port}.`);
