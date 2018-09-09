//const [a, b, ...rest] = ['Bob', 'Bobson', 24, true];//спред оператор забирає остачу массивом
//console.log(a);
//console.log(b);
//console.log(rest);
//const obj = {
//    name: 'Steave',
//    age: 24
//};

//const { name, age } = obj;///деструктуризация 
//console.log(name);
//console.log(age);

//function foo(...rest) {
//    console.log(rest);
//}
//foo(1, 2, 3);

//class Child {
//    //...
//    foo() {
//        //..s
//    }
//}
//export /*export default*/ class Parent extends Child {
//    constructor(a) {
//        super();
//        this.a = a;
//    }
//    showA() {
//        super.foo();
//    }
//}

//const parent = new Parent(5);
//parent.showA();

//promise ES6
//const promise = new Promise((resolve, reject => {
//    console.log(true);
//}));
//promise
//    .then(result => console.log('Ready ' + result) )
//    .catch(error => console.error(error));
//console.log(promise);