function add() {
    var content = document.getElementById("clicks");
    var clicks = content.innerText;
    clicks++;
    content.innerText = clicks;
}

function subtract() {
    var content = document.getElementById("clicks");
    var clicks = content.innerText;
    clicks--;
    content.innerText = clicks;
}

function restart() {
    var content = document.getElementById("clicks");
    var clicks = content.innerText;
    clicks = 0;
    content.innerText = clicks;
}