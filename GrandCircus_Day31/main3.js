var program = {
    main: function() {
        console.log(babyBoy);
    },
    handleClick: function() {
        var babyBoy = document.getElementById("babyBoy");
        let header = babyBoy.children.item(0);

        var listItem = document.createElement("li");
        listItem.TEXT_NODE = "I'm Adam lol";
    }
}

program.main();