//view
var view = {
    showNumber: function (num) {
        var el = document.getElementById('showResult');
        el.innerText = num;
    }
}
//model
var model = {
    number: 0,
    calculate: function (x, y) {
        this.number = x + y;
        view.showNumber(this.number);
    }
}
//controller
var controller = {
    handleClick: function () {
        model.calculate(3,4);
    }
}
    //init
    (function () {
        var app = {
            init: function () {
                this.event();
            },
            event: function () {
                var el = document.getElementById('calc');
                el.click = controller.handleClick;
            }
        }
        app.init();
    })()