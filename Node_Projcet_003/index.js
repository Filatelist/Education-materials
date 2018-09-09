const http = require('http');
let server = http.createServer(function(req, res) {
  res.writeHead(200, {'Content-Type': 'text/plain'});
  res.end('200 good');
});
server.listen(3000, '192.168.31.169')
console.log('Port 3000');
