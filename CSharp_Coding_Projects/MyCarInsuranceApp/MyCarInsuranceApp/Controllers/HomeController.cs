using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*
You must get the following information from the user:

First Name
Last Name
Email Address
Date of Birth
Car Year
Car Make
Car Model
If they have ever had a DUI.
How many speeding tickets they have.
Would they like full coverage or liability?

Use the following rules to calculate a quote:
Start with a base of $50 / month.
If the user is under 25, add $25 to the monthly total.
If the user is under 18, add $100 to the monthly total.
If the user is over 100, add $25 to the monthly total.
If the car's year is before 2000, add $25 to the monthly total.
If the car's year is after 2015, add $25 to the monthly total.
If the car's Make is a Porsche, add $25 to the price.
If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
Add $10 to the monthly total for every speeding ticket the user has.
If the user has ever had a DUI, add 25% to the total.
If it's full coverage, add 50% to the total.

There must also be an Admin view for a site administrator. This page must:
Show all quotes issued, along with the user's first name, last name, and email address.
    */

namespace MyCarInsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel, string dui, string speedingTickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) || 
                string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(speedingTickets) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                //using (MyCarInsuranceAppEntities db = new MyCarInsuranceAppEntities())//CHANGE TO NEW ENTITY
                //{
                //    var signup = new SignUp();
                //    signup.FirstName = firstName;
                //    signup.LastName = lastName;
                //    signup.EmailAddress = emailAddress;
                //    signup.DateOfBirth = dateOfBirth;
                //    signup.CarYear = carYear;
                //    signup.CarMake = carMake;
                //    signup.CarModel = carModel;
                //    signup.Dui = dui;
                //    signup.SpeedingTickets = speedingTickets;
                //    signup.Coverage = coverage;

                //    db.SignUps.Add(signup);
                //    db.SaveChanges();
                //}
                return View("Success");
            }
        }


    }
}