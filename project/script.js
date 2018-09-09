window.SpeechRecognition || window.SpeechRecognition
var recognition = new SpeechRecognition();
recognition.addEventListener('result', function (event) {
    var transcript = Array.from(event.result)
        .map(function (result) { return result[0]; })
        .map(function (result) { return result.transcript }).join('');
});
recognition.addEventListener('end', recognition.start);
recognition.start();