const fs = require('fs');
const myReadShort = fs.createReadStream(__dirname + '/article.txt', 'utf-8');
const myWriteShort = fs.createWriteStream(__dirname + '/new.txt');
myReadShort.pipe(myWriteShort);
