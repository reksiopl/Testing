var connect = require('connect');
var serveStatic = require('serve-static');

connect().use(
    serveStatic("./")

).listen(5000);

console.log('Server running at http://127.0.0.1:5000/');
