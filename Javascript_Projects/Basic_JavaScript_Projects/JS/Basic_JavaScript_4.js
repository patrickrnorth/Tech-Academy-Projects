function my_Dictionary() {
    var Beverages = {
        Brand: "Pepsi",
        Color: "Blue",
        Size: "16oz",
        Cost: ".99 cents"
    }
    document.getElementById("Dictionary").innerHTML = Beverages.Brand;   

}

function my_Dictionary2() {
    var Beverages = {
        Brand: "Pepsi",
        Color: "Blue",
        Size: "16oz",
        Cost: ".99 cents"
    }
    delete Beverages.Size;
    document.getElementById("Dictionary2").innerHTML = Beverages.Size;   

}