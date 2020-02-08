using System;
using System.Collections.Generic;

namespace Data.DB_Models
{
    public partial class TblSongs
    {
        public long Id { get; set; }
        public long? GenreId { get; set; }
        public long? AlbumId { get; set; }
        public long? ArtistId { get; set; }
        public string Name { get; set; }
        public TimeSpan? Time { get; set; }
        public decimal Price { get; set; }
        public int? Rating { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual TblMasterAlbum Album { get; set; }
        public virtual TblMasterArtist Artist { get; set; }
        public virtual TblMasterGenre Genre { get; set; }
    }
}
