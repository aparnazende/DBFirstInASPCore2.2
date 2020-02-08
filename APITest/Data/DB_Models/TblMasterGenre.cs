using System;
using System.Collections.Generic;

namespace Data.DB_Models
{
    public partial class TblMasterGenre
    {
        public TblMasterGenre()
        {
            TblSongs = new HashSet<TblSongs>();
        }

        public long Id { get; set; }
        public string MusicType { get; set; }
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
