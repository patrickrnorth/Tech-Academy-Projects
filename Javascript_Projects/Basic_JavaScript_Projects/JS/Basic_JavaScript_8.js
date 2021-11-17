/********CONCAT METHOD************ */
function myConcat() {
    var a = "The soda ";
    var b = "I prefer to ";
    var c = "drink most often ";
    var d = "is Pepsi";
    var myFavSoda = a.concat(b,c,d);
    document.getElementById("Fav_Soda").innerHTML = myFavSoda;
}

/********SLICE METHOD************ */
function slice_Method () {
    var Sentence = "Slice is a product of Pepsi Co. that was introduced in 1984, my birthyear, and discontinued in the late 2000s";
    var Section = Sentence.slice(9,31);
    document.getElementById("Slice").innerHTML = Section;
}

/********ToUpperCase METHOD************ */
function myUpperCase() {
    var pepsiPres = "The current president of Pepsi Co. is Mr. Ramon Laguarta";
    var pepsiPresUpper = pepsiPres.toUpperCase();
    document.getElementById("Pepsi_Pres").innerHTML = pepsiPresUpper;
}

/*********SEARCH METHOD */
function mySearch() {
    var pepsiTrivia = "Pepsi was the first soft drink company to use two-lite bottles.";
    var pepsiSearch = pepsiTrivia.search("first soft drink company");
    document.getElementById("Soda_Search").innerHTML = pepsiSearch;
}

/*************NUMBER TO STRING METHOD************* */
function string_method() {
    var x = 1984;
    document.getElementById("Numbers_to_string").innerHTML = x.toString();
}

/***********TO PRECISION METHOD********** */
function precision_Method() {
    var x = 4985.48484954651654;
    document.getElementById("Prescision").innerHTML = x.toPrecision(10);
}

/***********TO FIXED METHOD************ */
function myToFixed() {
    var myNum = 12.3456789;
    document.getElementById("Fixed_Num").innerHTML = myNum.toFixed(3);
}

/***********VALUE OF METHOD*************** */
function myValueOf() {
    var myString = "Pepsi was the first product to be advertised using skywriting.";
    document.getElementById("ValueOf_Pepsi").innerHTML = myString.valueOf();
}