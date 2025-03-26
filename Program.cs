
namespace modul6_103022300046
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //membuat object user
            SayaTubeUser user = new SayaTubeUser("Rakha ");

            //membuat object video 
            SayaTubeVideo film1 = new SayaTubeVideo("Review Film Shazam oleh Rakha");
            SayaTubeVideo film2 = new SayaTubeVideo("Review Film Thor oleh Rakha");
            SayaTubeVideo film3 = new SayaTubeVideo("Review Film Captain America oleh Rakha");
            SayaTubeVideo film4 = new SayaTubeVideo("Review Film Ironman oleh Rakha");
            SayaTubeVideo film5 = new SayaTubeVideo("Review Film Batman oleh Rakha");
            SayaTubeVideo film6 = new SayaTubeVideo("Review Film Superman oleh Rakha");
            SayaTubeVideo film7 = new SayaTubeVideo("Review Film Justice League oleh Rakha");
            SayaTubeVideo film8 = new SayaTubeVideo("review Film Spiderman oleh Rakha");
            SayaTubeVideo film9 = new SayaTubeVideo("Review Film Captain Marvel oleh Rakha");
            SayaTubeVideo film10 = new SayaTubeVideo("Review Film Avengers oleh Rakha");

            //memasukkan video
            user.AddVideo(film1);
            user.AddVideo(film2);
            user.AddVideo(film3);
            user.AddVideo(film4);
            user.AddVideo(film5);
            user.AddVideo(film6);
            user.AddVideo(film7);
            user.AddVideo(film8);
            user.AddVideo(film9);
            user.AddVideo(film10);

            //mencetak semua video playcount
            user.PrintAllVideoPlayCount();
            
        }
    }
}