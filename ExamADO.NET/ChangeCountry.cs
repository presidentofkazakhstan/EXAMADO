using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
  public  class ChangeCountry
    {
        public ChangeCountry()
        {
            using (var context = new ExamContext())
            {
                Console.Write("Введите ID изменяемой страны: ");
                int idCountry = int.Parse(Console.ReadLine());

                Console.Write("Введите новое название страны: ");
                string newNameCountry = Console.ReadLine();


                Console.Write("Введите новое кол-во людей: ");
                int newPopulationCountry = int.Parse(Console.ReadLine());


                var results = context.Countries.ToList().Where(x => x.Id == idCountry);
                foreach (var country in results)
                {
                    country.Name = newNameCountry;
                    country.Population = newPopulationCountry;
                }

                context.SaveChanges();
            }
        }
    }
}
