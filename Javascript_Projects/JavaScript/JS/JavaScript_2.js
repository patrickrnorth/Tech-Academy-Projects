//form validator
function validateForm() {
   // var x = document.forms["myForm"]["fname"].value;
    if (document.myForm.fname.value =="") {
        alert("First name must be filled out!");
        return false
    }
    if (document.myForm.lname.value =="") {
        alert("Last name must be filled out!");
        return false
    }
    if (document.getElementById("wrongChoice").checked) {           //shows the user the error of their beverage beliefs.
        alert("Pepsi must be checked!");
        return false
    }
    if (document.getElementById("wrongChoiceAgain").checked) {      //shows the user the error of their beverage beliefs.
        alert("Pepsi must be checked!");
        return false
    }
}