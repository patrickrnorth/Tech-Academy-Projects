function myMathFunctionSub() {
    var subtraction = 4-2;
    document.getElementById("math").innerHTML = "2 minus 2 is: " + subtraction; 

}

function myMathFunctionMultiplication() {
    var x = 5 * 2;
    document.getElementById("math").innerHTML = "2 times 2 is: " + x; 

}

function myMathFunctionDiv() {
    var x = 9 / 3;
    document.getElementById("math").innerHTML = "9 divided by 3 is: " + x; 

}

function myMathFunctionMultiOp() {
    var x = 2 + (2 * 5);
    document.getElementById("math").innerHTML = "2 times five plus 2 is: " + x; 

}

function myMathFunctionMod() {
    var x = 10 % 8;
    document.getElementById("math").innerHTML = "The remainder of 10 divided by 8 is: " + x; 

}

function myMathFunctionNeg() {
    var x = 5;
    document.getElementById("math").innerHTML = "The negative of 5 is: " + -x; 

}

function myMathFunctionIncrement() {
    var x = 10;
    x++;
    document.getElementById("math").innerHTML = "10 incremented by 1 is: " + x; 

}

function myMathFunctionDecrement() {
    var x = 10;
    x--;
    document.getElementById("math").innerHTML = "10 decremented by 1 is: " + x; 

}

function myMathFunctionRandom() {
    var x = Math.random() * 1000;
    document.getElementById("math").innerHTML = "Random number 0-1000: " + x; 

}

function myMathFunctionPi() {
    var x = Math.PI;
    document.getElementById("math").innerHTML = "PI rounded is: " + x; 

}




