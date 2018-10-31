using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AL3_P13
{
    class UniqueItem
    {
        private static int nextId { get; set; }
        private static int count = 0;
        private static int checkExistance { get; set; } // проверяем существование ранее созданного класса
        public int Id { get; private set; }
        public UniqueItem()
        {
            count++;
            Id = (int)nextId;
            nextId++;
        }
        public UniqueItem(int first)
        {            
            if (count == 0)
            {
                Id = first;
                nextId = first;
            }
            else
                Id = nextId;    
            nextId++;
            count++;
        }
    }
}
