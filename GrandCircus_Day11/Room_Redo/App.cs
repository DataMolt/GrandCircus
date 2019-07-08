using System;
using System.Collections.Generic;
using System.Text;

namespace Room_Redo
{
    public static class App
    {
        public static void Run()
        {
            Console.WriteLine("Please enter the length and width of the room: ");

            Console.Write("Please enter the length: ");
            var length = int.Parse(Console.ReadLine());

            Console.Write("Please enter the width: ");
            var width = int.Parse(Console.ReadLine());

            Console.Write("Please enter the height: ");
            var height = int.Parse(Console.ReadLine());


            var room = new Room(length, width, height);

            Console.WriteLine($"Room area: {room.GetArea()}");
            Console.WriteLine($"Room perimiter: {room.GetPerimiter()}");
            Console.WriteLine($"Room volume: {room.GetVolume()}");


        }
    }
}
