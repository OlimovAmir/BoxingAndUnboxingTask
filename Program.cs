using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoxingAndUnboxingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intfive = 5;//Число 5 хранится в stack
            object objFive = intfive;//Число 5 копируеться 

            int intFive2 = 5;//Число 5 хранится в stack
            object objFive2 = intFive2;//Число 5 копируеться 

            bool isIntEqual = intfive == intFive2;
            Console.WriteLine(isIntEqual);//Здесь будет True, потому что 5 ровно 5 

            bool isObjEqual = objFive == objFive2;
            Console.WriteLine(isObjEqual);//Здесь будет false, потому что пути разные
           Console.ReadKey();
        }
        
    }
}
