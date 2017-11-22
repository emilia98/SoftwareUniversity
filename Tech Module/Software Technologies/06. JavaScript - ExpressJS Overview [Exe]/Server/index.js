const http = require('http');
const port = 8070;

http.createServer( (req, res) => {
	res.end('Hello from Node.js!');
}).listen(port);

console.log(`App listening on ${port}`);
