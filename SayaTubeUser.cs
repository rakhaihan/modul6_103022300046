using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_103022300046
{
    //membuat class SayaTubeUser
    internal class SayaTubeUser
    {
        //membuat atribut
        private int id;
        private List<SayaTubeVideo> uploadedVideos;
        public string Username;

        //membuat constructor
        public SayaTubeUser(string username)
        {
            //precondition username tidak boleh lebih dari 100 karakter
            Contract.Requires(username.Length <= 100, "username tidak boleh lebih dari 100 karakter");

            //precondition username tidak boleh null
            Contract.Requires(!string.IsNullOrEmpty(username), "username tidak boleh kosong");

            if (username.Length > 100)
            {
                throw new ArgumentException("username tidak boleh lebih dari 100 karakter");
            }

            if (string.IsNullOrEmpty(username))
            {
                throw new ArgumentException("username tidak boleh kosong");
            }

            this.Username = username;
            this.id = new Random().Next();
            this.uploadedVideos = new List<SayaTubeVideo>();
        }

        //membuat method GetTotalVideoPlayCount
        public int GetTotalVideoPlayCount()
        {
            int total = 0;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                total += video.GetPlayCount();
            }
            return total;

        }

        //membuat method AddVideo
        public void AddVideo(SayaTubeVideo video)
        {
            //precondition video tidak boleh null
            Contract.Requires(video != null, "video tidak boleh null");

            //precondition video yang ditambahkan punya playcount yang kurang dari integer maksimum
            Contract.Requires(video.GetPlayCount() <= int.MaxValue, "video yang ditambahkan punya playcount yang kurang dari integer maksimum");

            if (video == null)
            {
                throw new ArgumentException("video tidak boleh null");
            }

            if (video.GetPlayCount() > int.MaxValue)
            {
                throw new ArgumentException("video yang ditambahkan punya playcount yang kurang dari integer maksimum");
            }

            this.uploadedVideos.Add(video);
        }

        //membuat method PrintAllVideoPlayCount
        public void PrintAllVideoPlayCount()
        {

            Console.WriteLine("User: " + this.Username);
            
            //menambahkan postcondition maksimal video yang diprint adalah 8
            for(int i = 1; i <= Math.Min(8, uploadedVideos.Count); i++)
            {
                Console.WriteLine($"Video {i} judul: {uploadedVideos[i - 1].GetTitle()}");
            }
        }
    }
}
