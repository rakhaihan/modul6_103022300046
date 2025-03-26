using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
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
            //precondition judul video tidak boleh lebih dari 200 karakter
            Contract.Requires(title.Length <= 200, "judul video tidak boleh lebih dari 200 karakter" );

            //precondition judul video tidak boleh null
            Contract.Requires(!string.IsNullOrEmpty(title), "judul video tidak boleh kosong");

            
            //menambahkan exception
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("judul video tidak boleh kosong");
            }

            if (title.Length > 200)
            {
                throw new ArgumentException("judul video tidak boleh lebih dari 200 karakter");
            }

            Random random = new Random();

            //id random
            this.id = random.Next(10000, 99999);
            this.title = title;
            this.playCount = 0;
        }

        //membuat method IncreasePlayCount
        public void IncreasePlayCount(int playCount)
        {
            //precondition penambahan playcount max 25.000.000 per panggilan method
            Contract.Requires(playCount <= 25000000, "penambahan playcount max 25.000.000 per panggilan method");

            //precondition playcount tidak boleh negatif
            Contract.Requires(playCount >= 0, "playcount tidak boleh negatif");

            //menambahkan exception
            if (playCount > 25000000)
            {
                throw new ArgumentException("penambahan playcount max 25.000.000 per panggilan method");
            }

            if (playCount < 0)
            {
                throw new ArgumentException("playcount tidak boleh negatif");
            }

            //menggunakan checked
            checked
            {
                this.playCount += playCount;
            }
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
