const fs = require('fs');
let myReadShort = fs.createReadStream(__dirname + "/text.txt");
myReadShort.on('data', function(chunk){
  console.log('new data is inside\n' + chunk);
  
});
