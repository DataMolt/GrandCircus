//avoid collision
var main2Script = {
    app: function() {
        console.log("avoiding collision");
    }
}

main2Script.app();

//self calling function
(function() {
    var dog = "vinnie";
    console.log(dog);
})()

var program = {
    main: function() {
        alert("CLICK HERE TO FIND HOT SINGLES IN YOUR AREA");
        this.validateNumber();
    },
    validateNumber: function(input) {
        let isValidating = true;
        while (isValidating) {
            let userInput = prompt("enter your ssn lol");
            let numINput = parseInt(userInput);
            if (isNaN(numINput)) {
                alert("enter it right ok its safe")
            } else {
                return numINput;
            }
        }
    }
}

program.main();