const express = require('express');
const app = express();
const homeController = require('./controllers/homeController');
const port = 1400;
app.listen(port);


////Handlebars config
//View engine setup
app.set('views', 'views');
app.set('view engine', 'hbs');

/*app.post('/', (req, res) => {
    //res.send('Hello from Express!');

});*/

app.get('/', homeController.homeGet);

/*
    For courses or users, each of whom has its/his/her won unique ID.
    If we want to display the given course/user, we can use this.
 */

app.get('/courses/:courseId', (req, res) => {
    let currentCourseId = +req.params.courseId;
    res.send(`<p>This is course with id <span style="color: red">${currentCourseId} </span>.`);
});

app.get('/files/*', (req, res) => {
    res.send(`PATH: <span style="color: green">${req.path}`);
});

console.log(`App is listening on port ${port}.`);
