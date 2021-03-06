﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CarInsuranceApp.Models
{
    public class CarInsuranceAppApply
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string DateOfBirth { get; set; }
        public string CarYear { get; set; }
        public string CarMake { get; set; }
        public string CarModel { get; set; }
        public string Dui { get; set; }
        public string SpeedingTickets { get; set; }
        public string Coverage { get; set; }
        public int InsuranceQuote { get; set; }

        
        //Will calculate an insurance quote based on the parameters passed by the applicant
        public int CalcInsuranceQuote(string dateOfBirth, int carYear, string carMake, string carModel, string dui, string speedingTickets, string coverage)
        {
            int quoteTotal = 50;
                        
            DateTime DateOfBirth = Convert.ToDateTime(dateOfBirth);
            int currentAge = Convert.ToInt32(DateTime.Now.Year - DateOfBirth.Year);
            int CarYear = Convert.ToInt32(carYear);
            string CarMake = carMake.ToLower();
            string CarModel = carModel.ToLower();
            int SpeedingTickets = Convert.ToInt32(speedingTickets);
            int Dui = Convert.ToInt32(dui);
            string Coverage = coverage.ToLower();

            if (currentAge < 25 && currentAge > 18) { quoteTotal += 25; }
            if (currentAge < 18) { quoteTotal += 100; }
            if (currentAge > 100) { quoteTotal += 25; };
            if (CarYear < 2000) { quoteTotal += 25; };
            if (CarYear > 2015) { quoteTotal += 25; };
            if (CarMake == "porsche") { quoteTotal += 25; };
            if (CarMake == "porsche" && CarModel == "911 carrera") { quoteTotal += 25; };
            if (SpeedingTickets > 0) { quoteTotal += (10 * SpeedingTickets); }
            if (Dui > 0) { quoteTotal += Convert.ToInt32(quoteTotal * 1.25f); }
            if (Coverage == "full coverage") { quoteTotal = Convert.ToInt32(quoteTotal * 1.50f); }

            return quoteTotal;
        }
    }   
}