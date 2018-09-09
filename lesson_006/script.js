var btn_menu = document.getElementById('button_menu'),
    db,
    indexedDB = window.indexedDB || window.mozIndexedDB || window.webkitIndexedDB;

function manipulateData(event) {
    var action = event.target.getAttribute('data-key'),
        open = indexedDB.open('MyDatabase', 1);

    // open.onupgradeneeded = function () {
    //     db = open.result;
    //     return db.createObjectStore('MyObjectStore', {keyPath: 'id'})
    //         .createIndex('NameIndex', ['name.last', 'name.first']);
    // };

    open.onsuccess = function () {
        db = open.result;

        var tx = db.transaction('MyObjectStore', 'readwrite'),
            store = tx.objectStore('MyObjectStore'),
            index = store.index('NameIndex');

        if (action === 'add') {
            store.add({ id: 12345, name: { first: 'John', last: 'Doe' }, age: 34 });
            store.add({ id: 67890, name: { first: 'Bob', last: 'Bobson' }, age: 28 });
        } else if (action === 'get') {
            var getItemByKey = store.get(67890);
            getItemByKey.onsuccess = function (data) {
                console.log(data.target.result);
            }
        } else if (action === 'update') {
            store.put({ id: 12345, name: { first: 'Steve', last: 'Doe' }, age: 34 });
        } else if (action === 'remove') {
            store.delete(67890);
        }

        tx.oncomplete = function () {
            db.close();
        }
    };

    open.error = function () {

    }
}

btn_menu.addEventListener('click', manipulateData, false)