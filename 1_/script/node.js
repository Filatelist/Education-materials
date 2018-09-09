//прості вирази - вирази які є літералами або числами або this. base і тд
//var num;//declaration statement
//num = 2;
//console.log(num);
// var n , j , h =10;
// var m = "kek";
 //console.log(h);
//console.log(typeof h);
//console.log(m);
//console.log(typeof m);
//var N = new Number(7);
/*console.log(typeof n);*///object 
//console.log(N.toFixed(2));
////console.log(N.toExponential(8));
//console.log(0.2 + 0.1);//мова js використовує дійсні числа
////console.log("ffff \"g\" assds");
//console.log(Boolean(5));// true
//console.log(Boolean(undefined));
//console.log(Boolean(null));
//console.log(Boolean(0));
//console.log(Boolean(NaN));
//console.log(Boolean(""));//false
//var isTrue = false, f = 7;
//if (!isTrue) { console.log(f); }
//else {
//    console.log(isTrue);
//}
//function MyFunc(nam)
//{
//    if (nam >=0)
//        return 2 + nam;
//    else {
//        return 0;
//    }
//}
////console.log(MyFunc(0)); == var method = function(name){return name}
//function Method(name) {
//    return "Hello" + name;
//}
////console.log(Method("Kek"));
//var greet = function (name) {
//    console.log(arguments.length);
//    return name;
//}
//console.log(greet("Name", 69)); // 2 Name;
//var func = function () {
//    return function () {
//        console.log("rand lover");
//    }
//};
//func()();// rand lover;
//var greeting = (function (name) {
//    return "Hello " + name;
//}("Sorax");
//)
// Локальні і глобальні змінні
//var i = 5; // глобальна
//var func = function () {
//    var i = 10;
//    console.log(i);
//    var innerfunc = function () {
//        var i = 15;
//        console.log(i);
//    };
//    innerfunc();
//    console.log(i);
//};
//func();
//var counter = (function () {
//    var count = 0;
//    return function (num) {
//        if (num != undefined) {

//            return count+num;
//        }
//    }
//}());
//for (var i = 0; i < 10; i++) {
//    console.log(counter(i));

//}
//var person =
//    {
//        name: "Name",
//        age: 19,
//        gender: "male"
//    }
//person.age = 18;
//console.log(person);
//var greet = function (greeting) {
//    return greeting + " my name is " + this.name;
//}
//var person1 = {
//    name: "Andrew",
//    age: 20,
//    greet: greet
//};
//var person2 = {
//    name: "Robert",
//    age: 19,
//    greet: greet
//}
//console.log(person1.greet());
//console.log(person2.greet.call(person1)); //call - ключове слово яке показує на який об'єкт вказує this
//console.log(person2.greet.call(person1, "Hi"));
//console.log(person2.greet.apply(person2, ["hello"]));
//var bound = greet.bind(person2);
//console.log(bound("Hi there"));
//var person = {
//    name: "Andrew",
//    Age: 20,
//    get age() {
//        return this.Age;
//    },
//    set age(value) {
//        if (value > 0 & value < 122) {
//            this.Age = value;
//        } else this.Age = 0;
//    }
//};
//person.age = 10;
//console.log(person.age);
//person.age = 188;
//console.log(person.age);
//person.age = 34;
////console.log(person.age);
//console.log(Object.getOwnPropertyDescriptor(person, "name"));
//var avarage = function (x, y) {
//    return (x + y) / 2;
//}
//console.log(avarage(10, 20));
//function getIt()
//{
//    return this.x;
//}
//var objectone = { get: getIt, x: 1 }
//var objecttwo = { get: getIt, x: 2 }
//console.log(
//    objectone.get());
//console.log(objecttwo.get);
//console.log('________________________');
//this - вказує на змінну звідки ми викликаємо функцію
//функція може бути властивістю класа
//var obj = {
//    base: 13,
//    avarage: function (x) {
//        return x / 2;
//    }
//function greeting(name) {
//    var text = "Helo " + name;
//    var greet = function () {
//        console.log(text);
//    }
//    return greet;
//}
//function Human(name) {
//    this.name = name;
//}
//Human.prototype.say = function (what) {
//    console.log(this.name + ": " + what);
//}
//var alex = new Human("Alex");
//console.log(alex);
//console.log(alex.say("Hello"));
//function func(a) {
//    var b = a + a;
//    return b + a;
//}
////console.log(func(5));
//console.log(typeof null);
//var a = 5;
//(function () {
//    console.log(a);
//    var a = 6;
//})();=> undefined
//var arr = []; //конкретні значення
//var obj = {
//    a: 3,
//    get: function () { console.log(this.a); }
//}; //ключ значення
//obj.get();
//var obj = new Object.create({ b: 4 });
//console.log(obj);
//var obj = {
//    a: 1,
//    b: 2,
//    c: 3
//};
//for (var i in obj) {
//    if (obj.hasOwnProperity) {
//        console.log(obj[i]);
//    }
//}
//var string = 'Hello'; //строка немутабельна
//str = 'Bob';
//console.log(str); //створюэтсья постійно копія строки
//var a = 2 + 3;//немутабельна
//var array = [1, 2, 3, 4]; //копіювання по посиланню
//var arr2 = array;
//arr2.push(5);
//console.log(array);
//var obj = {
//    a: 1,
//    b: 2,
//    c: 4
//},obl = {};
//for (var prop in obj) {
//    obl[prop] = obj[prop];
//}
//console.log(obl);


//function truncateString(str, num) {
//    var trimmed = [];
//    if (num > str.length) { return str; }
//    else
//        if (num != str.length) {
//            for (var i = 0; i < num; i++) {
//                trimmed[i] = str[i]
//            }
//            return trimmed.join('').toString() + "...";
//        } else return str;
//}
//console.log(truncateString("A-tisket a-tasket A green and yellow basket", 8))
//console.log(truncateString("Peter Piper picked a peck of pickled peppers", 11));
//console.log(truncateString("A-tisket a-tasket A green and yellow basket", "A-tisket a-tasket A green and yellow basket".length));
//console.log(truncateString("A-tisket a-tasket A green and yellow basket", "A-tisket a-tasket A green and yellow basket".length + 2));
//console.log(truncateString("A-", 1));
//console.log(truncateString("Absolutely Longer", 2));

function findElement(arr, func) {
    for (var i = 0; i < arr.length; i++) {
        if (func(arr[i])) {
            return arr[i]
            break;
        } ;
    }
}

console.log(findElement([1, 3, 4], num => num % 2 === 0));