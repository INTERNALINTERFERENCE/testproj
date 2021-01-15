using IMDbApiLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetInformationAboutMovie
{
    public class MovieDataDetail
    {
        public  int Id { get; set; }
        public string Title { set; get; } 
        public string OriginalTitle { get; set; }
        public DateTime? ReleaseDate { set; get; }
        public string Image { get; set; }
        public double Popularity { get; set; }
        public string Overview { get; set; }
        public string Directors { set; get; }
        public List<StarShort> DirectorList { get; set; }
        public List<ActorShort> ActorList { get; set; }
        public string Genres { set; get; }
        public string Countries { set; get; }
        public string ContentRating { get; set; }
        public string IMDbRating { get; set; }
        public string MetacriticRating { set; get; }
    }
}
