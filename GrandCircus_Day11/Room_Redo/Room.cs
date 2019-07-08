using System;
using System.Collections.Generic;
using System.Text;

namespace Room_Redo
{
    public class Room
    {
        public int Length { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Room(int length, int width, int height)
        {
            Length = length;
            Width = width;
            Height = height;
        }

        public int GetArea()
        {
            return Length * Width;
        }

        public int GetPerimiter()
        {
            return (Length + Width) * 2;
        }

        public int GetVolume()
        {
            return GetArea() * Height;
        }

    }
}
