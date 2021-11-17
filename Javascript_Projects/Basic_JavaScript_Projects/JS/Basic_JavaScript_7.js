/****************GLOBAL VARIABLE*****************/
var x = 10;
function Sub_Numbers_1Global() {
    document.write(20 - x + "<br>");
}

function Sub_Numbers_2Global() {
    document.write(x -5 + "<br>");
}
Sub_Numbers_1Global();
Sub_Numbers_2Global();

/*************LOCAL VARIABLE********************/

function Sub_Numbers_1Local() {
    var y=7;
    document.write(20 - y + "<br>");
}

function Sub_Numbers_2Local() {
    document.write(y -5);
}
Sub_Numbers_1Local();
Sub_Numbers_2Local();

/***************BUGGY CODE W/CONSOLE******************/

function Sub_Numbers_Bug() {
        var z=7;
        console.log(20 - z + "<br>");
}
    
function Sub_Numbers_2Bug() {
        console.log(z -5 +"<br>");
}
Sub_Numbers_1Local();
Sub_Numbers_2Local();

/**************IF STATEMENT*******************/

function get_Date() {
    if (new Date().getHours() <20) {
    document.getElementById("Greeting").innerHTML = "It is before 8pm!";
    }
}

/**************PERSONAL IF FUNCTION*******************/

function myIFStatement() {
    var Pepsi = 10;
    var Coke = 8;
    if (Pepsi>Coke) {
        document.getElementById("Soda").innerHTML = "Pepsi does taste better than Coke!";
    }
}

/*****************IF/ELSE FUNCTION****************/

function scoreFunction() {
    Score = document.getElementById("Pepsi_Score").value;
    if (Score >= 8) {
        Opinion = "You have impeccable taste in Soda!";
    }
    else {
        Opinion = "I'm sorry to say you enjoy inferior sodas. Good day.";
    }
    document.getElementById("myOpinion").innerHTML = Opinion;
}


/****************DATE FUNCTION*****************/

function Time_Function() {
    var Time = new Date().getHours();
    var Reply;
    if (Time < 12 == Time > 0) {
        Reply = "It is morning time!";
    }
    else if (Time > 12 == Time < 18) {
        Reply = "It is the afternoon.";
    }
    else {
        Reply = "It is evening time."
    }
    document.getElementById("Time_of_day").innerHTML = Reply;
}