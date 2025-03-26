
namespace modul6_103022300046
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Contoh valid");

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

                //menambahkan video
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

                film1.IncreasePlayCount(10);
                film2.IncreasePlayCount(20);
                film3.IncreasePlayCount(30);
                film4.IncreasePlayCount(40);
                film5.IncreasePlayCount(50);
                film6.IncreasePlayCount(60);
                film7.IncreasePlayCount(70);
                film8.IncreasePlayCount(80);
                film9.IncreasePlayCount(90);
                film10.IncreasePlayCount(100);

                user.PrintAllVideoPlayCount();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                Console.WriteLine("\nContoh membuat user invalid");

                //membuat object user
                Console.WriteLine("user berupa huruf a sebanyak 101");
                SayaTubeUser user = new SayaTubeUser(new string('a', 101));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                Console.WriteLine("\nContoh membuat video invalid");

                //membuat object video 
                Console.WriteLine("judul video berupa huruf a sebanyak 201");
                SayaTubeVideo film = new SayaTubeVideo(new string('a', 201));
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                Console.WriteLine("\nContoh membuat video invalid");

                //membuat object video 
                Console.WriteLine("judul video kosong");
                SayaTubeVideo film = new SayaTubeVideo(null);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                Console.WriteLine("\nContoh membuat playcount invalid");

                //membuat object video 

                SayaTubeVideo film = new SayaTubeVideo("Review Film Shazam oleh Rakha");
                Console.WriteLine("playcount melebihi 25000000");
                film.IncreasePlayCount(25000001);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            try 
            {
                Console.WriteLine("\nContoh membuat playcount invalid");

                //membuat object video 
                SayaTubeVideo film = new SayaTubeVideo("Review Film Shazam oleh Rakha");
                Console.WriteLine("playcount kurang dari 0");
                film.IncreasePlayCount(-1);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}