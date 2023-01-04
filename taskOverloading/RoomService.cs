using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace taskOverloading
{
    internal class RoomService:IRoomService
    {
       
        public void CreateRoom(int no, int price,Otel otel)
        {
            Rooms room = new Rooms
            {
                No = no,
                Price = price, 
            };
            Array.Resize(ref otel.Rooms, otel.Rooms.Length + 1);

            otel.Rooms[otel.Rooms.Length - 1] = room; 
        }

       

        public void ReserveRooms(int no,Otel otel)
        {
            string rezerve_message = "";
            
                for (int i = 0; i < otel.Rooms.Length; i++)
                {

                    if (otel.Rooms[i].No == no)
                    {
                        if (otel.Rooms[i].IsReserved == false) {
                            otel.Rooms[i].IsReserved = true;
                        rezerve_message = "Otaq Rezerv olundu";
                        break;

                        } 

                    }else
                    {
                    rezerve_message = "Bu momrede otaq yoxdur ve ya rezerv olunub";
                    }
                    }
            Console.WriteLine(rezerve_message);
        }

        public void ShowRooms(Otel otel)
        {
            for (int i = 0; i < otel.Rooms.Length; i++)
            {
                Console.WriteLine($"Otaqin Nomresi {otel.Rooms[i].No}, Otaqin qiymeti: {otel.Rooms[i].Price} manat , Rezerv olunma statusu: {otel.Rooms[i].IsReserved}");
            }
        }
    }
}
