using Data.DB_Models;
using Services.ViewModel;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Services.Repository
{
    public class AlbumDetails:IAlbumDetails
    {
        private readonly DB_MusicContext _context;

        public AlbumDetails(DB_MusicContext context)
        {
            _context = context;
        }

        public async Task<ResponseViewModel> GetAlbumDetails(IdViewModel idViewModel)
        {
            ResponseViewModel response = new ResponseViewModel();
            try
            {
               // ResponseViewModel response = new ResponseViewModel();
                var list = await _context.TblSongs.ToListAsync();
                if (list.Count() > 1)
                {
                    var songsList = (from i in list
                                     where
                     i.ArtistId == idViewModel.ArtistId
                     & i.AlbumId == idViewModel.AlbumId
                     & i.GenreId == idViewModel.AlbumId
                                     select new SongDetailsViewModel
                                     {
                                         Name = i.Name,
                                         Rating = i.Rating,
                                         Price = i.Price,
                                         Time = i.Time

                                     }).ToList();

                    var returnList = (from s in _context.TblSongs
                                      join a in _context.TblMasterAlbum on s.AlbumId equals a.Id
                                      join ar in _context.TblMasterArtist on s.ArtistId equals ar.Id
                                      join g in _context.TblMasterGenre on s.GenreId equals g.Id
                                      select new AlbumDetailsViewModel
                                      {
                                          GenreName = g.MusicType,
                                          albumName = a.Name,
                                          ArtistName = ar.FirstName + " " + ar.LastName,
                                          Thumbnail = a.Image,
                                          Price = a.Price,
                                          Rating = a.Rating,
                                          Review = a.Review,
                                          ReleaseDate = a.ReleasedDate,

                                      }).FirstOrDefault();
                    if (returnList != null)
                        returnList.Songs = songsList;
                    if (list.Count() == 0)
                    {
                        response.IsSuccess = false;
                        response.Message = "RecordNotFound";
                        return response;
                    }
                    response.Content = returnList;
                    response.IsSuccess = true;                  
                    response.Message = "RecordFound";
                    return response;
                }
            }
            catch (System.Exception)
            {

                throw;
            }
            return response;
        }
    }
}
