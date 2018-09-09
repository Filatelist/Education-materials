var clickButton = document.querySelector('button[type="button"]'),
    singup_form = document.getElementById('signup_form'),
    username = document.getElementById('usernameForSignUp'),
    password = document.getElementById('passwordForSignUp'),

    result, error,
    receivedData;
clickButton.setAttribute('disabled', 'true');

function handleSubmit(event) {
    event.preventDefault();
    receivedData = {
        userName: username.value,
        password: password.value
    };
    if (username.value.length < 3) {
        getErrorResult();
    } else {
        this.reset();
        singup_form.style.display = 'none';
        getSuccessResult();
        error.style.display = 'none';
    }
}

function getSuccessResult() {
    result = document.createElement('h1');
    result.innerText = 'You logged in successfully!';
    document.body.appendChild(result);
}

function getErrorResult() {
    error = document.createElement('span');
    error.innerText = 'Wrong username format!';
    error.style.color = 'red';
    document.body.appendChild(error);
}

function handleInput() {
    if (username.value.length > 0 && password.value.length > 0) {
        clickButton.disabled = false;
    }
}

username.addEventListener('input', handleInput, false);
password.addEventListener('input', handleInput);
form.addEventListener('submit', handleSubmit, false);