using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ViewModel
{
   public class AlbumDetailsViewModel
    {
        public string GenreName { get; set; }
        public string albumName { get; set; }
        public string ArtistName { get; set; }
        public string Thumbnail { get; set; }
        public decimal? Price { get; set; }
        public int? Rating { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public string Review { get; set; }
        public List<SongDetailsViewModel> Songs = new List<SongDetailsViewModel>();

    }

    public class SongDetailsViewModel
    {
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public int? Rating { get; set; }
        public TimeSpan? Time { get; set; }
    }
}
