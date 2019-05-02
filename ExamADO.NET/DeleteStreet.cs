using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
  public  class DeleteStreet
    {
        public DeleteStreet()
        {
            using (var context = new ExamContext())
            {
                foreach (var street in context.Streets)
                {
                    Console.WriteLine($"id: {street.Id} Name: {street.Name}  Population: {street.Population}");
                }


                Console.Write("Введите ID удаляемого города: ");
                int idStreet = int.Parse(Console.ReadLine());


                var results = context.Streets.ToList().Where(x => x.Id == idStreet);
                foreach (var street in results)
                {
                    context.Streets.Remove(street);
                }

                context.SaveChanges();


            }
        }
    }
}
