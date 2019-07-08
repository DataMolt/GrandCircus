let name = "adam";

if  (name.length > 3) {
    console.log("that's a dope ass name");
}

for (let index = 0; index < name.length; index++) {
    console.log(name[index]);    
}

let counter = 0;
while (counter < 10) {
    console.log("HELP");
    counter++;
}

function printInput(input) {
    console.log(input);
}

printInput(name);
printInput(2);
printInput(true);

let dog = {
    name: "fido",
    age: 10,
    bark: function() {
        console.log("BARK");
    }
}

dog.bark();

class Animal {
    name = "Lenny the Animal";
    collar = true;
    legs = 16;
    owner = "OG up top";

    constructor(name, collar, legs, owner) {
        this.name = name;
        this.collar = collar;
        this.legs = legs;
        this.owner = owner;
    }

    makeNoise = function() {
        console.log("kill me...");
    }
}

var animal = new Animal("Jack", false, 0, "Nobody");

var nameArray = ["could", "it", "be", "butter?"];

for (let name of nameArray) {
    console.log(name);
}

var animals = [ new Animal("jimmy", false, 2, "wife")];

for (let animal of animals) {
    console.log(`${animal.name} ${animal.collar} ${animal.legs} ${animal.owner}`);
}
