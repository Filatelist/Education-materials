var input = document.createElement('input');
var param = document.createElement('p');
input.setAttribute('type', 'text');
document.body.appendChild(input);
document.body.appendChild(p);
input.addEventListener('input', function (event) {
    
    p.innerText = this.value.toUpperCase();
}, false);