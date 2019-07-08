let counter = "";
let value1 = null;
let value2 = null;
let plusOrMinus = "";

$('.button').click(function() {
    counter += this.id;
    $('.answer').text(counter);
});

$('#plus').click(function() {
    if (value1 === null) {
        value1 = parseInt(counter);
        counter = "";
        plusOrMinus = "+";
        $('.answer').text(0);
    } 
});

$('#minus').click(function() {
    if (value1 === null) {
        value1 = parseInt(counter);
        counter = "";
        plusOrMinus = "-";
        $('.answer').text(0);
    } 
});

$('#equals').click(function() {
    if (value2 === null) {
        value2 = parseInt(counter);
        counter = "";
        if (plusOrMinus === "+") {
            $('.answer').text(value1 + value2);
        } else if (plusOrMinus === "-") {
            $('.answer').text(value1 - value2);
        } else {
            console.log("hehe");
        }
        value1 = null;
        value2 = null;
        counter = "";
        plusOrMinus = "";
    } 
});