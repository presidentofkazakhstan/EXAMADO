using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
  public  class ChangeObject
    {
        public ChangeObject()
        {
            Console.WriteLine("1 - изменить страну");
            Console.WriteLine("2 - изменить город");
            Console.WriteLine("3 - изменить улицу");
            int selectNumber = int.Parse(Console.ReadLine());


            if (selectNumber == 1)
            {
                ChangeCountry changeCountry = new ChangeCountry();
            }
            else if (selectNumber == 2)
            {
                ChangeCity changeCity = new ChangeCity();
            }

            else if (selectNumber == 3)
            {
                ChangeStreet changeStreet = new ChangeStreet();
            }


            else { Console.WriteLine("ERROR"); }
        }
    }
}
