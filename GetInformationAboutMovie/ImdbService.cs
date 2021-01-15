using GetInformationAboutMovie.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TMDbLib.Client;
using TMDbLib.Objects.General;
using TMDbLib.Objects.Search;

namespace GetInformationAboutMovie
{
    public class TmdbService
    {
        private static JsonConfig _config = new JsonConfig();
        private static TMDbClient _client = new TMDbClient("dd47404357d7dfca4f753c17e666f789");

        public static async Task<MovieDataDetail> GetAllMovieInfo(string title, string lang = "ru")
        {
            var results = await _client.SearchMovieAsync(title, lang);
            var data = results.Results.FirstOrDefault(p => p.Title == title);
            Console.WriteLine(data.Overview); //works good
            return new MovieDataDetail
            {
                Id = data.Id,
                Title = data.Title,
                OriginalTitle = data.OriginalTitle,
                Overview = data.Overview,
                ReleaseDate = data.ReleaseDate
            };
        }
        
        public static void Display()
        {
            MovieDataDetail detail = new MovieDataDetail();
            Console.WriteLine(detail.Overview); // idk why but it doesn't work
        }
    }
}

