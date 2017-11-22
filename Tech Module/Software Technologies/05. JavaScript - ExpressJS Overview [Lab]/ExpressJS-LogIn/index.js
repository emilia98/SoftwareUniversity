const express = require('express');
const app = express();
const bodyParser = require('body-parser');

app.get('/', (req, res) => 
	res.send(`
		<h1>Welcome to my first app</h1>
		<a href="login">To continue, please login</a>
	`)
);

app.use(bodyParser.urlencoded(
{
	extended: true
}));

app.get('/login', (req, res) =>
	res.send(`
		<form method="post">
		    <div style="margin: 5px 0">
				<label for="username" style="display: inline-block;width: 80px"> Username: </label>
				<input type="name" name="username" id="username"/>
			</div>
			<div style="margin: 5px 0">
				<label for="passWord" style="display: inline-block;width: 80px"> Password: </label>
				<input type="password" name="passwd" id="passWord"/>
			</div>
			<input type="submit" value="Submit"/>
		</form>
	`)
);

app.post('/login', function(req, res) {
	let postedData = req.body;
	if(postedData.username == "guest" && postedData.passwd == "12345"){
		res.redirect("/welcome");
	}else{
		res.send(`
			<h1 style="color: red">Invalid username or password!</h1>
			<a href="/">Go back to homepage</a>
		`);
	}	
}
);

app.get('/welcome', function(req, res) {
	res.send(`<h1 style="color: green">Welcome, user!</h1>`);
}
);

app.get('/logged', (req, res) => {
	res.send(`
		<h1 style="color: blue; text-align: center">You are logged in. Choose what to do next.</h1>
	`);
});

//For showing a user by his/her ID
app.get('/users/:id', (req, res) => {
	res.send('Showing user: ' + req.params.id + `</br>` + `<a href="/logged">Go back to homepage</a>`);	
});

//For showing (and maybe downloading) a file (and it's path)
app.get('/browse/files/*', (req, res) => {
	res.send('File requested: ' + req.path + `</br>` + `<a href="/logged">Go back to homepage</a>`);
});

app.get('/users', (req, res) =>
	res.send(`
		<h1>Users</h1>
		<p>The users are: 
			<ul>
				<li>Pesho</li>
				<li>Gosho</li>
			</ul>
		</p>
	`)
);

app.listen(3000, () => console.log('Example app listening on port 3000!'));