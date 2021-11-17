function Ride_Function() {
    var Height, Can_ride;
    Height = document.getElementById("Height").value;
    Can_ride = (Height < 52) ? "You are too short" : "You are tall enough";
    document.getElementById("Ride").innerHTML = Can_ride + " to ride.";

}

function Vote_Function() {
    var Age, Can_vote;
    Age = document.getElementById("Age").value;
    Can_vote = (Age < 18) ? "You are too young" : "You are old enough";
    document.getElementById("Vote").innerHTML = Can_vote + " to vote.";

}

function Vehicle(Make, Model, Year, Color) {
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year = Year;
    this.Vehicle_Color = Color;
}
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik =new Vehicle("Ford", "Pinto", 1971, "Mustard");

function myFunction() {
    document.getElementById("Keywords_and_Constructors").innerHTML = 
    "Erik drives a " + Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model +
    " manufactured in " + Erik.Vehicle_Year + ".";
}

function Beverage(Brand, Size, LabelColor, Price) {
    this.Beverage_Brand = Brand;
    this.Beverage_Size = Size;
    this.Beverage_LabelColor = LabelColor;
    this.Beverage_Price = Price;
}
var Pepsi = new Beverage("Pepsi", "32oz", "Blue", "$0.99")
var Tropicana = new Beverage("Orange Juice", "1 Gallon", "Orange", "$4.99")


function BeverageFunction() {
    document.getElementById("New_and_This").innerHTML = 
    "Ryan's favorite beverage is a " + Pepsi.Beverage_Size + " " + Pepsi.Beverage_Brand + " with a label color of " + Pepsi.Beverage_LabelColor + " and priced at " + Pepsi.Beverage_Price + ".";
}

function countDown_Function() {
    document.getElementById("Counting_Down").innerHTML = CountDwn();
    function CountDwn() {
        var Starting_Point = 10;
        function Minus_One() {Starting_Point -= 1;}
        Minus_One();
        return Starting_Point;
    }
}