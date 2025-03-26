using System;
using System.Collections.Generic;
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
            this.uploadedVideos.Add(video);
        }

        //membuat method PrintAllVideoPlayCount
        public void PrintAllVideoPlayCount()
        {
            Console.WriteLine("User: " + this.Username);
            int i = 1;
            foreach (SayaTubeVideo video in uploadedVideos)
            {
                Console.WriteLine ($"Video {i++} judul: { video.GetTitle()}");
            }
        }
    }
}
