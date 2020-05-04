function openModal() {
    document.getElementById("myModal").style.display = "block";
}

function closeModal() {
    document.getElementById("myModal").style.display = "none";
}

var slideIndex = 1;
showSlides(slideIndex);

function plusSlides(n) {
    showSlides(slideIndex += n);
}

function currentSlide(n) {
    showSlides(slideIndex = n);
}
function showSlides(n) {
    var i;
    var slides = document.getElementsByClassName("mySlides");
    var dots = document.getElementsByClassName("demo");
    var captionText = document.getElementById("caption");
    if (n > slides.length) {slideIndex = 1}
    if (n < 1) {slideIndex = slides.length}
    for (i = 0; i < slides.length; i++) {
        slides[i].style.display = "none";
    }
    for (i = 0; i <slides.length; i++) {
        dots[i].className = dots[i].className.replace(" active", "");
    }
    slides[slideIndex-1].style.display = "block";
    dots[slideIndex-1].className += " active";
    captionText.innerHTML = dots[slideIndex-1].alt;
}

function validateForm() {
      
    var errorMessage = "";

    if (document.forms["myForm"]["fname"].value == "") {
        errorMessage += "Enter your First name\n";               
    }
    
    if (document.forms["myForm"]["lname"].value == "") {
        errorMessage += "Enter your Last name\n";              
    }

    if (document.forms["myForm"]["email"].value == "") {
        errorMessage += "Enter your Email\n";              
    }

    if(document.forms["myForm"]["phone"].value =="") {
        errorMessage += "Enter your Phone Number";        
    }

    if (errorMessage != "") {
        alert(errorMessage);
        return false;
    }
}

function openForm() {
    document.getElementById("myPopupForm").style.display = "block";
}

function closeForm() {
    document.getElementById("myPopupForm").style.display ="none";
}

