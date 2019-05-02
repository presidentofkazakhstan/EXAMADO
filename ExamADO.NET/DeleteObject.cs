using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
  public  class DeleteObject
    {
        public DeleteObject()
        {
            Console.WriteLine("1 - удалить страну");
            Console.WriteLine("2 - удалить город");
            Console.WriteLine("3 - удалить улицу");
            int selectNumber = int.Parse(Console.ReadLine());


            if (selectNumber == 1)
            {
                DeleteCountry deleteCountry = new DeleteCountry();
            }
            else if (selectNumber == 2)
            {
                DeleteCity deleteCity = new DeleteCity();
            }

            else if (selectNumber == 3)
            {
                DeleteStreet deleteStreet = new DeleteStreet();
            }


            else { Console.WriteLine("ERROR"); }
        }
    }
}
