function typeOF() {
    document.write(typeof 10);
    
}

function infinity() {
    document.write(4E500);        
}

function negInfinity() {
    document.write(-4E500);        
}

function booleanEx1() {
    document.write(15>3);
}

function booleanEx2() {
    document.write(15<3);
}

function consoleEx1() {
    var x = console.log(2 + 2);
    document.write(x);
}

function coersionEx1() {
    document.write(150 + "25");
}

function comparisonTrue() {
    document.write(10==10);
}

function comparisonFalse() {
    document.write(10==5);
}



function threeEqualTrue() {
    document.write("10"==="10");
}

function threeEqualFalseFalse() {
    document.write(10==="5");
}

function threeEqualFalseTrue() {
    document.write(10==="10");
}

function threeEqualTrueFalse() {
    document.write(10===5);
}


function andOpTrue() {
    document.write(7>5 && 20>10);

}

function andOpFlase() {
    document.write(7<5 && 20>10);
}

function orOpTrue() {
    document.write(7<5 || 20>10);
}

function notOpTrue() {
    document.getElementById("Not").innerHTML = !(10<2);
}

function notOpFalse() {
    document.getElementById("Not").innerHTML = !(10>2);
}

