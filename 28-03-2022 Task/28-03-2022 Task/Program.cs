using _28_03_2022_Task.Models;
using System;

namespace _28_03_2022_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Singer sg = new Singer();
            sg.Name = "William";
            sg.Age = 200;
            Console.WriteLine(sg.Age);
            Songs song = new Songs();
            song.SongName = "Happy";

            //Console.WriteLine(song.singer.Age);

            song.AddRating(4);
            song.AddRating(5);
            song.AddRating(4.5);
            song.AddRating(12);
            Console.WriteLine(song.GetAverageRating());

            song.Genre = "Jazz";
            Console.WriteLine(song.Genre);

            song.Genre = "Rep";
            Console.WriteLine(song.Genre);



        }
    }
}
