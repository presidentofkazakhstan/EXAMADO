using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
    public class DeleteCity
    {
        public DeleteCity()
        {
            using (var context = new ExamContext())
            {
                foreach (var city in context.Cities)
                {
                    Console.WriteLine($"id: {city.Id} Name: {city.Name}  Population: {city.Population}");
                }


                Console.Write("Введите ID удаляемого города: ");
                int idCity = int.Parse(Console.ReadLine());


                var results = context.Cities.ToList().Where(x => x.Id == idCity);
                foreach (var city in results)
                {
                    context.Cities.Remove(city);
                }

                context.SaveChanges();


            }
        }
    }
}
