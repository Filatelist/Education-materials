onmessage = function (event) {
    console.log(event.data, 'message resived from main script');
    const workerResult = 'Result' + (event.data[0] * event.data[1]);
    console.log('to main ');
    postMessage(workerResult)
}