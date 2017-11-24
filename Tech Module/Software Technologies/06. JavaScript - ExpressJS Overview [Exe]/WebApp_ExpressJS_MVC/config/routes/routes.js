const homeController = require('../.././controllers/homeController');
const courseController = require('../.././controllers/courseController');
const loginController = require('../.././controllers/loginController');
const bodyParser = require('body-parser');


module.exports = (app) => {
    app.use(bodyParser({urlencoded: true}));
    app.get('/', homeController.homeGet);

    /*
        For courses or users, each of whom has its/his/her won unique ID.
        If we want to display the given course/user, we can use this.
     */

    app.get('/courses/:courseId', courseController.courseGet);

    app.get('/files/*', (req, res) => {
        res.send(`PATH: <span style="color: green">${req.path}`);
    });

    app.get('/login', loginController.loginGet);
    app.post('/login', loginController.loginPost);
};
