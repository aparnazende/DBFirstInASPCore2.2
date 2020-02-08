using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Services.Repository;
using Services.ViewModel;

namespace APITest.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlbumController : ControllerBase
    {
        private IAlbumDetails _albumDetails;
        public AlbumController()
        {
            _albumDetails = new AlbumDetails(new Data.DB_Models.DB_MusicContext());
        }
        //public AlbumController(IAlbumDetails albumDetails)
        //{
        //    _albumDetails = albumDetails;
        //}
        [HttpPost("GetAlbumDetails")]
        public async Task<IActionResult> GetAlbumDetails([FromBody] IdViewModel model)
        {
            try
            {
              var list= await _albumDetails.GetAlbumDetails(model);
                if (list == null)
                {
                    return BadRequest("SomethingWrong");
                }
                return Ok(list);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }


        }

    }
}