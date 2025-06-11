using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProfileImageApi.Models;

namespace ProfileImageApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfilePicturesController : ControllerBase
    {
        private const string BaseUrl = "https://localhost:44397/images/";

        private static readonly List<ProfilePicture> ProfilePictures = new()
        {

             new ProfilePicture { Id = 1, Url = $"{BaseUrl}profilbild00.png", Description = "Blond kille" },
    new ProfilePicture { Id = 2, Url = $"{BaseUrl}profilbild0.png", Description = "Blond kille min" },
    new ProfilePicture { Id = 3, Url = $"{BaseUrl}profilbild1.png", Description = "Brunhårig tjej" },
    new ProfilePicture { Id = 4, Url = $"{BaseUrl}profilbild2.png", Description = "Brunhårig tjej min" },
    new ProfilePicture { Id = 5, Url = $"{BaseUrl}profilbild3.png", Description = "Svarthårig kille" },
    new ProfilePicture { Id = 6, Url = $"{BaseUrl}profilbild4.png", Description = "Svarthårig kille min" },
    new ProfilePicture { Id = 7, Url = $"{BaseUrl}profilbild5.png", Description = "Rödhårig tjej" },
    new ProfilePicture { Id = 8, Url = $"{BaseUrl}profilbild6.png", Description = "Rödhårig tjej min" },
    new ProfilePicture { Id = 9, Url = $"{BaseUrl}profilbild7.png", Description = "Brunhårig kille" },
    new ProfilePicture { Id = 10, Url = $"{BaseUrl}profilbild8.png", Description = "Brunhårig kille min" },
    new ProfilePicture { Id = 11, Url = $"{BaseUrl}profilbild9.png", Description = "Blond tjej" },
    new ProfilePicture { Id = 12, Url = $"{BaseUrl}profilbild10.png", Description = "Blond tjej min" },
    new ProfilePicture { Id = 13, Url = $"{BaseUrl}profilbild11.png", Description = "Rödhårig kille" },
    new ProfilePicture { Id = 14, Url = $"{BaseUrl}profilbild12.png", Description = "Rödhårig kille min" },
    new ProfilePicture { Id = 15, Url = $"{BaseUrl}profilbild13.png", Description = "Svarthårig tjej" },
    new ProfilePicture { Id = 16, Url = $"{BaseUrl}profilbild14.png", Description = "Svart hårig tjej min" }


        };

        [HttpGet]

        public ActionResult<IEnumerable<ProfilePicture>> GetAllProfilePictures()
        {
            return Ok(ProfilePictures);
        }

        
    }
}
