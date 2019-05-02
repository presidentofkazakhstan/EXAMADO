using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
  public  class ChangeCity
    {
        public ChangeCity()
        {
            using (var context = new ExamContext())
            {
                Console.Write("Введите ID изменяемого города: ");
                int idCity = int.Parse(Console.ReadLine());

                Console.Write("Введите новое название города: ");
                string newNameCity = Console.ReadLine();


                Console.Write("Введите новое кол-во людей: ");
                int newPopulationCity = int.Parse(Console.ReadLine());


                var results = context.Cities.ToList().Where(x => x.Id == idCity);
                foreach (var city in results)
                {
                    city.Name = newNameCity;
                    city.Population = newPopulationCity;
                }

                context.SaveChanges();
            }
        }
    }
}
