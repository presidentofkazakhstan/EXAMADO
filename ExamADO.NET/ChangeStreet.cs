using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
 public   class ChangeStreet
    {
        public ChangeStreet()
        {
            using (var context = new ExamContext())
            {
                Console.Write("Введите ID изменяемого города: ");
                int idStreet = int.Parse(Console.ReadLine());

                Console.Write("Введите новое название города: ");
                string newNameStreet = Console.ReadLine();


                Console.Write("Введите новое кол-во людей: ");
                int newPopulationStreet = int.Parse(Console.ReadLine());


                var results = context.Streets.ToList().Where(x => x.Id == idStreet);
                foreach (var street in results)
                {
                    street.Name = newNameStreet;
                    street.Population = newPopulationStreet;
                }

                context.SaveChanges();
            }
        }
    }
}
