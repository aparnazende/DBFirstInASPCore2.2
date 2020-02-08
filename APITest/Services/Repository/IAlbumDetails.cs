using Services.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Services.Repository
{
   public interface IAlbumDetails
    {//dynamic GetAlbumDetails();
        Task<ResponseViewModel> GetAlbumDetails(IdViewModel idViewModel);
    }
}
