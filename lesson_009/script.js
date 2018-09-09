////read about manifest
////Etag
//if ('ServiceWorker' in navigator) {
//    navigator.serviceWorker.register('/service_worker.js')
//        .then(reg => { console.log("success" + reg); })
//        .catch(err = > { console.log("error" + err);})
//}
//const p = document.createElement('p');
//p.id = 'p';
//p.innerText = 'Copy Text';
//document.body.appendChild(p);
//p.addEventListener('click', copyElement);
//function copyElement() {
//    return navigator.clipboard.writeText(p.innerText)
//        .then(f => console.log('Success'))
//            .catch(c => console.log('error'))
        
//}
//web worker
//let first = document.getElementById('number1'),
//    second = document.getElementById('number2'),
//    result = document.querySelector('.result'),
//    myWorker;
//if (window.Worker) {
//    myWorker = new Worker('worker.js');
//}
//first.onchange = function () {
//    myWorker.postMessage([first.value, second.value]);
//    console.log('Message postet to worker');
//}
//second.onchange = function () {
//    myWorker.postMessage([first.value, second.value]);
//    console.log('Message postet to worker');
//}
//myWorker.onmessage = function (event) {
//    result.innerHTML = event.data;
//}
// Observer

// subscriber
// publisher

//function Click() {
//    this.handlers = [];
//}

//Click.prototype = {
//    subscribe: function (fn) {
//        this.handlers.push(fn);
//    },
//    unsubscribe: function (fn) {
//        this.handlers = this.handlers.filter(function (item) {
//            if (item !== fn) {
//                return item;
//            }
//        })
//    },
//    publish: function (o, thisObj) {
//        this.handlers.forEach(function (item) {
//            item.call(thisObj, o);
//        })
//    }
//};

//var click = new Click();
//click.subscribe('user');
//click.publish('event # 1', this);
