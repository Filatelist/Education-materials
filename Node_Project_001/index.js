// objects in the node js
//V8
//глобальний об'єкт global, console, (все що притаманне браузеру)
//console.console.log(__filename);
//let things = require('./things');
//console.log(things.some_value);
//console.log(things.arrayCounter([1,2,4,5,5,6]));
//console.log(things.multiply(5,2));
// const events = require('events');
// let myEmit = new events.EventEmitter();
// myEmit.on('some_event', function(text){console.log(text);});
// myEmit.emit('some_event', 'event handler')
const event = require('events'), util = require('util');
function Cars(model){
  this.model = model;
};
util.inherits(Cars, event.EventEmitter);

let bmw = new Cars('BMW'), audi = new Cars('Audi'), volvo = new Cars('Volvo');
let cars = [bmw, audi, volvo];
cars.forEach(function(car){
  car.on('speed', function(text){
    console.log(car.model + " speed is " + text);
  });
});
bmw.emit('speed', '254 km/h');
audi.emit('speed', '200 km/h');
volvo.emit('speed', '240 km/h');
