using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOverloading
{
    internal class Rooms
    {
        private static int _id=0;
        public readonly int Id;
        private int no;
        private int price;
        private bool isReserved;
        public int No { get { return no; } set { no = value; } }
        public int Price { get { return price; } set { price = value; } }
        public bool IsReserved { get { return isReserved; } set { isReserved = value; } }
        public Rooms()
        {
            _id++;
            Id = _id;
        }
    }
}
