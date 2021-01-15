using IMDbApiLib;
using IMDbApiLib.Models;
using System;
using System.Threading.Tasks;

namespace GetInformationAboutMovie
{
    public class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Enter the name of the movie:"); // paste Lucy, for example
            string title = Console.ReadLine();
            await TmdbService.GetAllMovieInfo(title);

            MovieDataDetail detail = new MovieDataDetail();
            Console.WriteLine(detail.Overview);
        }       
    }
}
