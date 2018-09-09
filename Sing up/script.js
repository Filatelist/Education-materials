var inputpass = document.querySelector('input[type="password"]'),
    seepass = document.getElementById('passshow'),
    inputusername = document.querySelector('input[type = username]'),
    inputemail = document.querySelector('input[type="text"]'),
    form = document.querySelector('.reg'), result = document.querySelector('.result'), error, receivedData,
    submitbutton = document.querySelector('.submit'), container = document.querySelector('.info');

seepass.addEventListener('mousedown', togglePass);
seepass.addEventListener('mouseup', hidePass);
submitbutton.addEventListener('click', handleSubmit);
function togglePass() {
    (inputpass.type == 'password') ? inputpass.type = 'text' : inputpass.type = 'password';
}
function hidePass() {
    (inputpass.type == 'text') ? inputpass.type = 'password' : inputpass.type = 'text';
}
function handleSubmit(event) {
    event.preventDefault();
    receivedData = {
        username: inputusername.value,
        password: inputpass.value,
        email: inputemail.value
    };
    if (receivedData.username.length < 3 && validate(receivedData.email)) {
        getErrorResult();
    } else {
        result.innerText = "You logged successfully";
        form.style.display = "none";
        validateUser();
        var serialobject = JSON.stringify(receivedData);
        localStorage.setItem('user', serialobject);
        
    }
}
function getErrorResult() {
    alert("Invalid data");
    inputusername.value = "";
    
}
function validate(email) {
    var reg = /^([A-Za-z0-9_\-\.])+\@([A-Za-z0-9_\-\.])+\.([A-Za-z]{2,4})$/;
    if (reg.test(email) === false) {
        return false;
    }
}
var usernam = document.createElement("input"), password = document.createElement("input"), ul = document.createElement('ul'), li = document.createElement('li'), li2 = document.createElement('li'), li3 = document.createElement('li'),
    submit = document.createElement('button'), p1 = document.createElement('p'), p2 = document.createElement('p');

submit.addEventListener('click', check);
function validateUser() {
    
    
    usernam.setAttribute("type", "text");
    password.setAttribute("type", "password");
    submit.innerText = "Submit";
    submit.style.color = "white";
    submit.style.backgroundColor = "#717171";
    submit.style.borderRadius = "8px";
    submit.style.width = "100px";
    submit.style.height = '40px';
    container.appendChild(ul);
    ul.appendChild(li);
    ul.appendChild(li2);
    ul.appendChild(li3);
    li.appendChild(usernam);
    li2.appendChild(password);
    li3.appendChild(submit);
}
function check(event) {
    event.preventDefault();
    var user = JSON.parse(localStorage.getItem('user'));
    if (usernam.value === user.username && password.value === user.password) {
        result.innerText = "success";
        container.style.display = "none";
        localStorage.clear();
    } else {
    result.innerText = "invalid login or pass";
     }
}
