using System;
using System.Collections.Generic;

namespace Data.DB_Models
{
    public partial class TblMasterArtist
    {
        public TblMasterArtist()
        {
            TblSongs = new HashSet<TblSongs>();
        }

        public long Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public DateTime? Dob { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public long MaritalStatus { get; set; }
        public string PhoneExtnNo { get; set; }
        public string PhotoPath { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDate { get; set; }

        public virtual ICollection<TblSongs> TblSongs { get; set; }
    }
}
