using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
   public class DeleteCountry
    {
        public DeleteCountry()
        {
            using (var context = new ExamContext())
            {
                foreach(var country in context.Countries)
                {
                    Console.WriteLine($"id: {country.Id} Name: {country.Name}  Population: {country.Population}" );
                }


                Console.Write("Введите ID удаляемой страны: ");
                int idCounty = int.Parse(Console.ReadLine());


                var results = context.Countries.ToList().Where(x => x.Id == idCounty);
                foreach (var country in results)
                {
                    context.Countries.Remove(country);
                }

                context.SaveChanges();

               
            }
        }
    }
}
