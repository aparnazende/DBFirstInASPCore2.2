using System;
using System.Collections.Generic;
using System.Text;

namespace Services.ViewModel
{
  public  class IdViewModel
    {
        public long Id { get; set; }
        public long? GenreId { get; set; }
        public long? AlbumId { get; set; }
        public long? ArtistId { get; set; }
    }
}
