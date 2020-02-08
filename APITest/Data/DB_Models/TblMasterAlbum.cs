using System;
using System.Collections.Generic;

namespace Data.DB_Models
{
    public partial class TblMasterAlbum
    {
        public TblMasterAlbum()
        {
            TblSongs = new HashSet<TblSongs>();
        }

        public long Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public DateTime? ReleasedDate { get; set; }
        public int? Rating { get; set; }
        public string Review { get; set; }
        public decimal? Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TblSongs> TblSongs { get; set; }
    }
}
