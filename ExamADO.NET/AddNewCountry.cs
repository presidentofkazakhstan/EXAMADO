using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
    class AddNewCountry
    {
        public AddNewCountry()
        {
            using (var context = new ExamContext())
            {

                


                Console.Write("Введите навзание улицы: ");
                var streetName = Console.ReadLine();
                Console.Write("Введите население на этой улице");
                int streetPopulation = int.Parse(Console.ReadLine());

                var newStreet = new Street()
                {
                    Name = streetName,
                    Population = streetPopulation
                };

                Console.Write("Введите название города:");
                var cityName = Console.ReadLine();

                Console.Write("Введите население этого города: ");
                int cityPopulation = int.Parse(Console.ReadLine());

                var newCity = new City()
                {
                    Name = cityName,
                    Population = cityPopulation,
                    Street = newStreet
                };

                Console.Write("Введите навзание страны: ");
                var countryName = Console.ReadLine();

                Console.Write("Введите население этой страны: ");
                int countryPopulation = int.Parse(Console.ReadLine());

                var newCountry = new Country()
                {
                    Name = countryName,
                    Population = countryPopulation,
                    City = newCity

                };

                context.Streets.Add(newStreet);

                context.Cities.Add(newCity);

                context.Countries.Add(newCountry);

                context.SaveChanges();



            }
        }
        
    }
}
