//Switch Statement
function myFirstSwitch() {
    var Bev_Output;
    var Beverage = document.getElementById("Bev_Input").value;
    var Bev_String_Right = "is a great beverage!";
    var Bev_String_Wrong = "is still an inferior beverage..."
    switch(Beverage) {
        case "Pepsi":
            Bev_Output = "Pepsi " + Bev_String_Right;
        break;
        case "Wine":
            Bev_Output = "Wine " + Bev_String_Right;
        break;
        case "Orange Juide":
            Bev_Output = "Orange Juice " + Bev_String_Right;
        break;
        case "Water":
            Bev_Output = "Water " + Bev_String_Right;
        break;
        case "Coke":
            Bev_Output = "Coke " + Bev_String_Wrong;
        break;
        case "Beer":
            Bev_Output = "Beer " + Bev_String_Right;
        break;
        default:
        Bev_Output = "Please enter a beverage name exactly as written on the above list.";
    }
    document.getElementById("mySwitch").innerHTML = Bev_Output;

}

//GetElementByClassName() Method

function tarAndFeather() {
    var A = document.getElementsByClassName("Click");
    A[0].innerHTML = "Pepsi is the best beverage!";
    A[1].innerHTML = "Thank you for your patience and have a great day!";
}

//Canvas Graphics radialGradient
function circleGrad() {
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");

    //Create gradiant
    var grd = ctx.createRadialGradient(75,50,5,90,60,100);
    grd.addColorStop(0, "blue");
    grd.addColorStop(1, "white");

    // Fill with gradient
    ctx.fillStyle = grd;
    ctx.fillRect(10,10,150,80);
}

//Canvas Graphics linearGradient
function linearGrad() {
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");

    //Create gradiant
    var grd = ctx.createLinearGradient(70,0,170,0);
    grd.addColorStop(0, "blue");
    grd.addColorStop(1, "white");

    // Fill with gradient
    ctx.fillStyle = grd;
    ctx.fillRect(20,100,150,100);
}