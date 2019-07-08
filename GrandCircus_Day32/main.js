var content = document.getElementById("content");

//content.innerText = "hehe";

document.getElementById("clicker2").onclick = function() {
    var content = document.getElementById("clicks");
    var clicks = content.innerText;
    clicks++;
    content.innerText = clicks;
}

function onButtonClick() {
    var content = document.getElementById("clicks");
    var clicks = content.innerText;
    clicks++;
    content.innerText = clicks;
}

function sillyFunction() {
    // value is within this scope
    let value = 5;
    return value;
}

let value = sillyFunction();

alert(value);

function anonInMe() {
    // anonymous function
    (function(){
        console.log("hehe");
    })();
}

anonInMe();

alert("hi class");

document.addEventListener("DOMContentLoaded", function() {
    document.getElementById("summary").innerText = "hello world";
});

// JQUery
$('#jquerytest').click(function() {
    console.log("jquery test");
});