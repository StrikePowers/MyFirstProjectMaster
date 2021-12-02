using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Models
{
    public class PersonImage
    {
        public string Name { get; set; } 
        public string Images { get; set; }
        public string Roles { get; set; }

        public PersonImage(string n, string i, string r)
        {
            Name = n;
            Images = i;
            Roles = r;
        }

        public static List<PersonImage> GetName()
        {
            return new List<PersonImage>
            {
                new PersonImage("Christ Pratt", "https://static1.colliderimages.com/wordpress/wp-content/uploads/guardians-of-the-galaxy-chris-pratt-slice.jpg?q=50&fit=contain&w=750&h=375&dpr=1.5", "Star Lord"),
                new PersonImage("Vin Diesal", "https://cdn.vox-cdn.com/thumbor/-fJVqBRZRtmIlnqABk0aXyH14gs=/78x0:872x529/920x613/filters:focal(78x0:872x529):format(webp)/cdn.vox-cdn.com/assets/3755363/Groot.jpg","Groot"),
                new PersonImage("Bradly Cooper", "https://static.independent.co.uk/2020/12/24/08/bradley-cooper-rocket.jpg?width=1368&auto=webp&quality=75", "Rocket")
            };
        }
    }
}
