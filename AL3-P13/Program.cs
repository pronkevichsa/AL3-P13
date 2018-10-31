using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL3_P13
{
    class Program
    {       
        static void Main(string[] args)
        {
            UniqueItem uI1 = new UniqueItem(5);
            UniqueItem uI2 = new UniqueItem();
            Console.WriteLine(uI1.Id);
            Console.WriteLine(uI2.Id);
            UniqueItem uI3 = new UniqueItem(200); //т.к. экземпляры класса уже созданы то игнорируем новую нумерацию
            Console.WriteLine(uI3.Id);            
        }
    }    
}
