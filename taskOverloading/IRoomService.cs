using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOverloading
{
    internal interface IRoomService
    {
        public void CreateRoom(int no,int price, Otel otel);
        public void ShowRooms(Otel otel);
        public void ReserveRooms(int id, Otel otel);
    }
}
