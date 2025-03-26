using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300046
{
    //membuat class SayaTubeVideo
    internal class SayaTubeVideo
    {
        //membuat atribut
        private int id;
        private string title;
        private int playCount;

        //membuat constructor
        public SayaTubeVideo(string title)
        {
            Random random = new Random();

            //id random
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        //membuat method IncreasePlayCount
        public void IncreasePlayCount(int playCount)
        {
            this.playCount += playCount;
        }

        //membuat method PrintVideoDetail
        public void PrintVideoDetail()
        {
            Console.WriteLine("Id: " + this.id);
            Console.WriteLine("Title: " + this.title);
            Console.WriteLine("PlayCount: " + this.playCount);
        }

        //membuat getter GetPlayCount
        public int GetPlayCount()
        {
            return this.playCount;
        }

        //membuat getter GetTitle
        public string GetTitle()
        {
            return this.title;
        }
    }
}
