using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOverloading
{
    internal class Otel:Rooms
    {
        private int id;
        private string name;
        public Rooms[] Rooms = new Rooms[0];
        public string Name { get { return name; } set { { name = value; } } }
    }
}
