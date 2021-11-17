/*     WHILE LOOP    */
function count_Down() {
    var Digit ="";
    var X = 10;
    while(X>-1) {
        Digit += "<br>" + X;
        X--;
    }
    document.getElementById("Counting_down_to_zero").innerHTML = Digit;
}

/*   FOR LOOP   */
var Beverages = ["Pepsi", "Orange Juice", "Water", "Beer", "Wine"];
var Content = "";
var Y;
function for_Loop() {
    for (Y = 0; Y < Beverages.length; Y++) {
        Content += Beverages[Y] + "<br>";
    }
    document.getElementById("List_of_Beverages").innerHTML = Content;
}

/*   Array   */
function array_Pepsi() {
    var Pepsi_Slogans = [];
    Pepsi_Slogans[0] = "Joy of Pepsi";
    Pepsi_Slogans[1] = "Pepsi. It's the Cola";
    Pepsi_Slogans[2] = "The Choice of a New Generation";
    Pepsi_Slogans[3] = "For Those Who Think Young";
    document.getElementById("Array").innerHTML = "One of Pepsi's sloagans is: " + Pepsi_Slogans[2] + "";

}

/* Const Keyword */
function constant_function() {
    const Soda_Beverage = {type:"Cola", brand:"Pepsi", color:"blue"};
    Soda_Beverage.brand = "Coke";
    Soda_Beverage.price = "0.99c";
   // Soda_Beverage = {Type: "Juice", brand:"Tropicana", color:"orange"}; TEST FOR CONSTANT 
    document.getElementById("Constant").innerHTML = "The cost of the " + Soda_Beverage.brand + " was " + Soda_Beverage.price;
}

/* Let Keyword */
function let_Pepsi() {
    var Pepsi = "The Best.";
    document.write(Pepsi);
    {
        let Pepsi = "Refreshing.";
        document.write("<br>" + Pepsi);
    }
    document.write("<br>" + Pepsi);
}

/* Let Keyword w/Object instantiation */
function myBev(){
    let Beverage = {
        type: "Soda",
        brand: "Pepsi",
        price: "$0.99",
        descritiption: function() {
            return "The beverage is a " + this.type + " named " + this.brand + " it costs " + this.price + ".";
        }
    }
    document.getElementById("Bev").innerHTML = Beverage.descritiption();
}
    
