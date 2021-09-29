using _01_ProfileClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Profile
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Bronze
            FacebookProfile user = new FacebookProfile();
            user.FirstName = "Richard";
            user.LastName = "Lionheart";
            user.AgeInInt = 44;
            user.Occupation = "King of Messenger";
            user.YearsAtJob = 12;
            Console.WriteLine(user.Occupation);
            Console.ReadLine();

            //Silver
            FacebookProfile fullName = new FacebookProfile();
            string full = fullName.FullName;
            Console.WriteLine(full);
            Console.ReadLine();
            

            //Gold

            FacebookProfile newUser = new FacebookProfile("Paul", "Revere", "male", "Silversmith", 22);
            Console.WriteLine(newUser.FullName, "\n");
            Console.WriteLine(newUser.Gender, "\n");
            Console.WriteLine(newUser.Occupation, "\n");
            Console.WriteLine(newUser.YearsAtJob);
            Console.ReadLine();

            
            
        {
                {
                    
                } 
                
        }
    }
    }
}
