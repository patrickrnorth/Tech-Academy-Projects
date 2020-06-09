using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using CarInsuranceApp.Models;
using CarInsuranceApp.ViewModels;

namespace CarInsuranceApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarInsuranceDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Apply(string firstName, string lastName, string emailAddress, string dateOfBirth, string carYear, string carMake, string carModel, string dui, string speedingTickets, string coverage)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress) || string.IsNullOrEmpty(dateOfBirth) || string.IsNullOrEmpty(carYear) ||
                    string.IsNullOrEmpty(carMake) || string.IsNullOrEmpty(carModel) || string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(speedingTickets) || string.IsNullOrEmpty(coverage))
            {
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                string queryString = @"INSERT INTO Applications (FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, Dui, SpeedingTickets, Coverage) VALUES
                                        (@FirstName, @LastName, @EmailAddress, @DateOfBirth, @CarYear, @CarMake, @CarModel, @Dui, @SpeedingTickets, @Coverage)";

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand(queryString, connection);
                    command.Parameters.Add("@FirstName", SqlDbType.VarChar);
                    command.Parameters.Add("@LastName", SqlDbType.VarChar);
                    command.Parameters.Add("@EmailAddress", SqlDbType.VarChar);
                    command.Parameters.Add("@DateOfBirth", SqlDbType.VarChar);
                    command.Parameters.Add("@CarYear", SqlDbType.VarChar);
                    command.Parameters.Add("@CarMake", SqlDbType.VarChar);
                    command.Parameters.Add("@CarModel", SqlDbType.VarChar);
                    command.Parameters.Add("@Dui", SqlDbType.VarChar);
                    command.Parameters.Add("@SpeedingTickets", SqlDbType.VarChar);
                    command.Parameters.Add("@Coverage", SqlDbType.VarChar);

                    command.Parameters["@FirstName"].Value = firstName;
                    command.Parameters["@LastName"].Value = lastName;
                    command.Parameters["@EmailAddress"].Value = emailAddress;
                    command.Parameters["@DateOfBirth"].Value = dateOfBirth;
                    command.Parameters["@CarYear"].Value = carYear;
                    command.Parameters["@CarMake"].Value = carMake;
                    command.Parameters["@CarModel"].Value = carModel;
                    command.Parameters["@Dui"].Value = dui;
                    command.Parameters["@SpeedingTickets"].Value = speedingTickets;
                    command.Parameters["@Coverage"].Value = coverage;

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }                
                return View("Success");
            }
        }
        
        public ActionResult Admin()
        {
            string queryString = @"SELECT Id, FirstName, LastName, EmailAddress, DateOfBirth, CarYear, CarMake, CarModel, Dui, SpeedingTickets, Coverage from Applications";
            List<CarInsuranceAppApply> applications = new List<CarInsuranceAppApply>();
            
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    var apply = new CarInsuranceAppApply();
                    apply.Id = Convert.ToInt32(reader["Id"]);
                    apply.FirstName = reader["FirstName"].ToString();
                    apply.LastName = reader["LastName"].ToString();
                    apply.EmailAddress = reader["EmailAddress"].ToString();
                    apply.DateOfBirth = reader["DateOfBirth"].ToString();
                    apply.CarYear = reader["CarYear"].ToString();
                    apply.CarMake = reader["CarMake"].ToString();
                    apply.CarModel = reader["CarModel"].ToString();
                    apply.Dui = reader["Dui"].ToString();
                    apply.SpeedingTickets = reader["SpeedingTickets"].ToString();
                    apply.Coverage = reader["Coverage"].ToString();
                    applications.Add(apply);
                }
            }

            var applyVMs = new List<ApplyVM>();
            
            foreach (var application in applications)
            {
                var applyVM = new ApplyVM();
                applyVM.FirstName = application.FirstName;
                applyVM.LastName = application.LastName;
                applyVM.EmailAddress = application.EmailAddress;
                
                applyVMs.Add(applyVM);
                
            }

            return View(applyVMs);
        }
        
    }
}