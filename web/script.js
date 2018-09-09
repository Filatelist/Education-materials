var constrains = {
    video: true,
    audio: false
}, spBtn = document.getElementById('snapshot'),
    filterSelect = document.querySelector('select#filter'),
    video = document.querySelector('video'),
    canvas = document.querySelector('canvas');
canvas.width = 480;
canvas.height = 360;
filterSelect.onchange = function () {
    video.className = filterSelect.value;
};
spBtn.onclick = function () {
    canvas.className = filterSelect.value;
    canvas.getContext('2d').drawImage(video, 0, 0, canvas.width, canvas.height);
}
function handleSuccess(stream) {
    window.stream = stream;
    video.srcObject = stream;
}
function handleError() {
    console.log('err');
}
navigator.mediaDevices.getUserMedia(constrains).then(handleSuccess).catch(handleError);