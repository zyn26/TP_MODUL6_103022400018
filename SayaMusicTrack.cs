using System;
using System.Collections.Generic;
using System.Text;

namespace TP_MODUL6_103022400018
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Random rand = new Random();
            this.id = rand.Next(10000, 99999); // 5 digit
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            playCount += count;
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"ID: {id}");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Play Count: {playCount}");
        }
    }
}
