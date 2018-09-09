const addItems = document.querySelector('.add-items'),
    itemsList = document.querySelector('.plates'),
    items = JSON.parse(localStorage.getItem('items')) || [];

function addItem(event) {
    event.preventDefault();
    const text = (this.querySelector('[name=item]')).value,
        item = {
            text,
            done: false
        };
    items.push(item);
    localStorage.setItem('items', JSON.stringify(items));
    populateList(items, itemsList);
    this.reset();
}

function populateList(plates = [], platesList) {
    platesList.innerHTML = plates.map((plate, i) => {
        return `
            <li class="li${i}">
                <input type="checkbox" id="item${i}" data-index="${i}" ${plate.done ? 'checked' : ''}>
                <label for="item${i}" class="label${i}">${plate.text}<button type="image" class="btne${i} btn" onclick="editFunc(${i})"><img src="image.png" class="edit"></button> <button type="image" class="btnd${i} btn" onclick = "deleteFunc(${i})"><img src="delete.png" class="delete edit"></button></label>
            </li>
        `;
    }).join('');
}

function toggleDone(event) {
    const el = event.target,
        index = el.dataset.index;
        items[index].done = !items[index].done;
        localStorage.setItem('items', JSON.stringify(items));
        populateList(items, itemsList);
}

populateList(items, itemsList);

addItems.addEventListener('submit', addItem);
itemsList.addEventListener('click', toggleDone);


function deleteFunc(i) {

    let li = document.querySelector(`.li${i}`);
        items.splice(i, i);
        itemsList.removeChild(li);
        localStorage.setItem('items', JSON.stringify(items));
        populateList(items, itemsList);
}
function editFunc(i) {

    let inp = document.querySelector(`.li${i}`), input = document.createElement('input'), label = document.querySelector(`.label${i}`);
    inp.removeChild(label);
    
}