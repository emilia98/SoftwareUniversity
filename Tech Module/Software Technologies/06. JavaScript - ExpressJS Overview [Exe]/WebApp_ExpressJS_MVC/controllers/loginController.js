
module.exports = {
    loginGet: (req, res) => {
        res.render('login',
            {
                body : `<form method="post">
    <div>
        <label id="userName">Username:</label>
        <input type="text" name="username" id="userName" />
    </div>

    <div>
        <label id="passWord">Password:</label>
        <input type="password" name="passwd" id="passWord" />
    </div>

    <input type="submit" name="submit-btn" value="Login"/>
</form>`}
        )
    },
    loginPost: (req, res) => {
        let username = req.body.username;
        let password = req.body.passwd;
        console.log(`My username is: ${username}. My passwoord is: ${password}`);
        res.redirect('/')
    }

};