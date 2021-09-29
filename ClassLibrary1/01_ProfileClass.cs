using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_ProfileClass
{
    public class FacebookProfile
    {
        //Bronze Facebook Profile Properties
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName  // Part of Silver
        {
            get { return $"{FirstName} {LastName}"; }
        }
        public int AgeInYears

        {
            get
            {
                TimeSpan yearSpan = DateTime.Now - DateOfBirth;
                double ageInYears = yearSpan.Days / 365.25;
                return Convert.ToInt32(Math.Floor(ageInYears));

             }
        }
        public int AgeInInt { get; set; }
        public string Occupation { get; set; }
        public int YearsAtJob { get; set; }
        public string Gender { get; set; }


        public DateTime DateOfBirth { get; set; }


        public FacebookProfile()
        {

        }

        public FacebookProfile(string firstName, string lastName, string gender, string occupation, int yearsAtJob)
        {
            FirstName = firstName;
            LastName = lastName;
            Gender = gender;
            Occupation = occupation;
            YearsAtJob = yearsAtJob;


        }



    }
}
