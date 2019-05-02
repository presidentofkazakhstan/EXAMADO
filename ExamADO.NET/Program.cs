using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamADO.NET
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new ExamContext())
            {
                


               

                Console.WriteLine("1 - добавить улицу, город , страну");
                Console.WriteLine("2 - удаление улиц, городов,стран");
                Console.WriteLine("3 - изменить улицу , город, страну");
                int selectNumber = int.Parse(Console.ReadLine());

                if(selectNumber == 1)
                {
                    AddNewCountry addNewCountry = new AddNewCountry();
                }

                else if (selectNumber == 2)
                {
                    DeleteObject deleteObject = new DeleteObject();
                }

                else if (selectNumber == 3)
                {
                    ChangeObject changeObject = new ChangeObject();
                }


                else { Console.WriteLine("ERROR"); }
            }
        }
    }
}
