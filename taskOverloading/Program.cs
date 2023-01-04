using taskOverloading;

Rooms rooms = new();
Otel otel = new();
RoomService roomService = new RoomService();
Console.WriteLine("1.Create new room");
Console.WriteLine("2.Show all rooms ");
Console.WriteLine("3.Rezerve a room");
Console.WriteLine("4.Stop the program");
int decision = Convert.ToInt32(Console.ReadLine());
while(decision != 4)
{
   
    if (decision == 1)
    {
        Console.WriteLine("Otaq Nomresi daxil edin");
        int otaq_nomresi = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Otaqin qiymetini daxil edin");
        int price = Convert.ToInt32(Console.ReadLine());
        roomService.CreateRoom(otaq_nomresi, price, otel);
    }
    else if (decision == 2)
    {
        roomService.ShowRooms(otel);
    }
    else if (decision == 3)
    {
        Console.WriteLine("Rezerv etmek istediyiniz otagin nomresini daxil edin");
        int no = Convert.ToInt32(Console.ReadLine()); 
        roomService.ReserveRooms(no,otel);
    }
    else {
        Console.WriteLine("Yanlish sechim etdiniz!");
    }
    Console.WriteLine("Yuxaridaki sechimlerden birini edin");
    decision = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("Cixdiniz!");